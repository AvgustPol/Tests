using MyClassLibraryForTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public class Shop : IShop
    {
        // i know, that i MUST NOT name all like this but life is too short to not 
        // write a funny stuff for someone, whos going to check my work xD
        IUselessClass uselessThing;

        public Shop(IUselessClass foo)
        {
            uselessThing = foo;
        }

        public decimal CalculatePrices(IList<Product> products)
        {

            decimal sum = 0;

            foreach (var product in products)
            {
                sum += product.Price;
            }

            sum = uselessThing.ReturnTheSameDecimal(sum);

            return sum;
        }

        public int CalculateAmount(IList<Product> products)
        {

            int sum = 0;

            foreach (var product in products)
            {
                sum += product.Amount;
            }

            sum = uselessThing.ReturnTheSameInt(sum);

            return sum;
        }
    }
}
