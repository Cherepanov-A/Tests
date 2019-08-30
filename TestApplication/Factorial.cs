using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Factorial
    {
        internal static int FactCount(int n)
        {
            int fact = 1;
            while (n>1)
            {
                fact *= n;
                n--;
            }
            return fact;
        }
    }
}
