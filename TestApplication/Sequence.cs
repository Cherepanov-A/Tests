using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Sequence
    {
        internal static bool Check(string src)
        {
            bool res = false;
            int a = 0;
            int b = 0;
            int c = 0;
            foreach (var item in src)
            {
                switch (item)
                {
                    case '(': a++;
                        break;
                    case ')': a++;
                        break;
                    case '{': b++;
                        break;
                    case '}': b++;
                        break;
                    case '[': c++;
                        break;
                    case ']': c++;
                        break;
                    default:
                        break;
                }
                if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
            }
            return res;
        }
    }
}
