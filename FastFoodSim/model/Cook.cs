using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodSim.model
{
    class Cook
    {
        public void CookDish()
        {
            OrderQueue list = OrderQueue.GetInstance();
            TakeAway readyList = TakeAway.GetInstance();
            Order order = list.GetOrder();
            //----------------------------
            readyList.PutOrder(order);
        }
    }
}
