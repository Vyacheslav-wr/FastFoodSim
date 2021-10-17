using FastFoodSim.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSim.controller
{
    class clientPickUpOrder
    {
        Form1 f1 = new Form1();
        private static TakeAway ta = TakeAway.GetInstance();
        public static void takeOrder() {
            while (true) {
                try
                {

                    Order order = ta.GetOrder();
                    Thread.Sleep(3000);
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
