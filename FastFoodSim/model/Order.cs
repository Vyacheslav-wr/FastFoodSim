using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSim.model
{
    class Order
    {
        private int orderNum;
        private string customerName;

        public Order() { }
        public Order(int orderNum,string customerName)
        {
            this.orderNum = orderNum;
            this.customerName = customerName;
        }

        public int getOrderNum() { return orderNum; }
        public void setOrderNum(int orderNum) { this.orderNum = orderNum; }
        public string getCustomerName() { return customerName; }
        public void setCustomerName(string customerName) { this.customerName = customerName; }

    }
}
