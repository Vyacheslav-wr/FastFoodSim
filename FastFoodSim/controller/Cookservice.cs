using FastFoodSim.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSim.controller
{
    public class CookService
    {
        static OrderQueue oq = OrderQueue.GetInstance();
        static TakeAway ta = TakeAway.GetInstance();
        public static Semaphore semaphore = new Semaphore(0, 100);
        private static Thread cook;

        public static void startCookService(int num)
        {
            cook = new Thread(new ParameterizedThreadStart(takeAndPlaceOrder));
            cook.Start(num);
        }

        public static void abortCookService()
        {
            cook.Abort();
        }
        public static void takeAndPlaceOrder(Object time) {
            int myTime = Convert.ToInt32(time);
            while (true) {
                semaphore.WaitOne();
                Order order;
                try
                {
                    order = oq.GetOrder();
                    oq.orderList.Remove(order);
                    if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).delete();
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).queueUpdate1();
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).progressQueue(order.getOrderNum());
                    }
                    Thread.Sleep(myTime * 1000);
                    ta.PutOrder(order);
                    if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).progressQueue(0);
                    }
                    if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).update2(order);
                    }

                }
                catch (Exception ex) { }
                ClientPickUpOrder.semaphore.Release();
            }
        }
    }
}
