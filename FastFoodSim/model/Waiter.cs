using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastFoodSim.model
{
    class Waiter
    {
        private static OrderQueue list = OrderQueue.GetInstance();
        int num = 0;
        public int PlaceOrder(string personName)
        {
            Thread.Sleep(1000);
            if (list.getLastOrder() == null)
                num = 1;
            else
                num = list.getLastOrder().getOrderNum() + 1;
            Order order = new Order(num,personName);
            list.AddOrder(order);
            return num;
        }
    }
}
