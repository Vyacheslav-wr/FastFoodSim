using FastFoodSim.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSim.controller
{
    class CookService
    {
        static OrderQueue oq = OrderQueue.GetInstance();
        static TakeAway ta = TakeAway.GetInstance();
        public static void takeAndPlaceOrder(Object time) {
            int myTime = Convert.ToInt32(time);
            while (true) {
                Order order;
                Thread.Sleep(1000);
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
                    Thread.Sleep(myTime*1000);
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
            }
        }
    }
}
