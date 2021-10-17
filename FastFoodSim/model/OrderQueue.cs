using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSim.model
{
    class OrderQueue
    {
        private static OrderQueue instance;
        public List<Order> orderList = new List<Order>();
        private Order lastOrder;
        public Order getLastOrder() { return lastOrder; }
        public void setLastOrder(Order lastOrder) { this.lastOrder = lastOrder; }
        
        public void AddOrder(Order order)
        {
            orderList.Add(order);
            lastOrder = order;
        }
        public Order GetOrder()
        {
            Order order = orderList.First();
            orderList.Remove(order);
            return order;
        }              

        public static OrderQueue GetInstance() {
            if (instance == null)
                instance = new OrderQueue();
            return instance;
        }
        private OrderQueue() { }
    }
}
