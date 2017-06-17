using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Product
    {
        public decimal Price { get; set; }
        public int Amount { get; set; }

        public Product(decimal newPrice, int newAmount)
        {
            Price = newPrice;
            Amount = newAmount;
        }
    }
}
