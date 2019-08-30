using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class StringSearch
    {
        internal static string StrSearch(string input)
        {
            List<string> uniqe = new List<string>();
            List<string> ununiqe = new List<string>();
            string[] source = input.Split(' ');
            for (int i = 0; i < source.Length; i++)
            {
                if (!(uniqe.Contains(source[i])) && !(ununiqe.Contains(source[i])))
                {
                    uniqe.Add(source[i]);
                }
                else
                {
                    uniqe.Remove(source[i]);
                    ununiqe.Add(source[i]);
                }
            }
            StringBuilder result = new StringBuilder();
            foreach (var item in uniqe)
            {
                result.Append(item + " ");
            }
            return result.ToString();
        }
    }
}
