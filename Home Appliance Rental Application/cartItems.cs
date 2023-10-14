using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Appliance_Rental_Application
{
    public class cartItems
    {
        public string Description {  get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public cartItems(string description, double price)
        {
            Description = description;
            Price = price;
        }
    }
}
