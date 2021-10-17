using FastFoodSim.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FastFoodSim.controller
{
    public class ClientPlaceOrder
    {
        private static OrderQueue oq = OrderQueue.GetInstance();
        static int num = 0;
        public static Semaphore semaphore = new Semaphore(0, 100);
        private static Thread customerPlaceOrder;

        public static void startPlaceOrder(int num) {
            customerPlaceOrder = new Thread(new ParameterizedThreadStart(placeOrder));
            customerPlaceOrder.Start(num);
        }

        public static void abortPlaceOrder() {
            customerPlaceOrder.Abort();
        }
        public static void placeOrder(Object time) {
            int myTime = Convert.ToInt32(time);
            while (true) {
                Customer customer = new Customer();
                Waiter waiter = new Waiter();
                num++;
                customer.setName("Oleg" + num);
                customer.setOrderNum(waiter.PlaceOrder(customer.getName()));
                if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                {
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).update(customer);
                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).queueUpdate1();
                }
                Thread.Sleep(myTime * 1000);
                CookService.semaphore.Release();
            }
        }
    }
}
