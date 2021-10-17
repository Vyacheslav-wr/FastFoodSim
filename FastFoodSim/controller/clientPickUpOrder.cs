using FastFoodSim.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSim.controller
{
    public class ClientPickUpOrder
    {
        Form1 f1 = new Form1();
        private static TakeAway ta = TakeAway.GetInstance();
        private static Thread customerTakeOrder;
        public static Semaphore semaphore = new Semaphore(0, 100);

        public static void startPickUp() {
            customerTakeOrder = new Thread(takeOrder);
            customerTakeOrder.Start();
        }

        public static void abortPickUp() {
            customerTakeOrder.Abort();
        }

        public static void takeOrder() {
            while (true) {
                semaphore.WaitOne();
                try
                {
                    Order order = ta.GetOrder();
                    Thread.Sleep(2000);
                    ta.readyOrders.Remove(order);
                    if (System.Windows.Forms.Application.OpenForms["Form1"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).delete2();
                    }
                }
                catch (Exception ex) { }

            }
        }
    }
}
