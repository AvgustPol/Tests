using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop
{
    public interface IShop
    {
        decimal CalculatePrices(IList<Product> products);
        int CalculateAmount(IList<Product> products);
        double CalculateCalories(IList<Product> products);
    }
}
