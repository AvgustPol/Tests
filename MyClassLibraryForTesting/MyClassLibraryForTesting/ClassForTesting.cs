using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibraryForTesting
{
    // small calculator. Easy and simple for testing.
    public class ClassForTesting
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0) throw new Exception("You can`t divide by zero!");
            return a / b;
        }

        // method for testing with MOCK
        public double AddAndMultiply(double a, double b)
        {
            double sum = Add(a, b);

            return sum * a * b;
        }
    }
}
