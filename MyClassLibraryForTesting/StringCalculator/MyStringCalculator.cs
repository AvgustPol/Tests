using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class MyStringCalculator
    {
        public string StringToLower(string newString)
        {
            return newString.ToLower();
        }

        public string StringToUpper(string newString)
        {
            return newString.ToUpper();
        }

        public int StringToInt(string newString)
        {
            return Int32.Parse(newString);
        }
    }
}
