using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSim.model
{
    class TakeAway
    {
        private static TakeAway instance;
        public List<Order> readyOrders = new List<Order>();

        public Order GetOrder()
        {
            Order order = readyOrders.First();
            readyOrders.Remove(order);
            return order;
        }
        public void PutOrder(Order order)
        {
            readyOrders.Add(order);
        }
        public Order FindByOrderNum(int num)
        {
            foreach (Order order in readyOrders)
            {
                if (order.getOrderNum() == num)
                    return order;
            }
            return null;
        }

        private TakeAway() { }
        public static TakeAway GetInstance()
        {
            if (instance == null)
                instance = new TakeAway();
            return instance;
        }
    }
}
