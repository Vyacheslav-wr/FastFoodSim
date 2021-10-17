using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSim.model
{
    public class Customer
    {
        private string name;
        private int orderNum;
        public Customer() { }
        public Customer(string name) { this.name = name; }
        
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }
        public int getOrderNum() { return orderNum; }
        public void setOrderNum(int orderNum) { this.orderNum = orderNum; }
    }
}
/*
 customer placed order
if(is ready)
 order goes to queue
 ...
 customer takes order

 */
