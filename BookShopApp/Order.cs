using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShopApp
{
    public class Order
    {
        public int CustomerID { get; set; }
        public double TotalPrice { get; set; } = 0;

        public Order(int customerID, double totalPrice)
        {
            CustomerID = customerID;
            TotalPrice = totalPrice;
        }   
    }
}
