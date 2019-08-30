using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace TestApplication
{
    internal class Presenter
    {
        private static int[] sArr { get; set; }
        internal static string Sort(string arrTxt)
        {
            
            string[] temp = arrTxt.Split(' ');
            if (temp.Length < 2)
            {
                return "This is not array";
            }
            int[] unsortArr = new int[temp.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                unsortArr[i] = Convert.ToInt32(temp[i]);
            }
            int[] sortArr = Sorter.IntSort(unsortArr);
            sArr = sortArr;
            StringBuilder result = new StringBuilder();
            foreach (var item in sortArr)
            {
                result.Append(item.ToString() + " ");
            }
            return result.ToString();
        }

        internal static string Search(int p)
        {
            int sw = Sorter.Search(sArr, p);
            string result;
            switch (sw)
            {
                case 1: result = "Item is listed";
                    break;
                case 0: result = "Array is empty";
                    break;
                case -1: result = "Item isn't listed";
                    break;
                default: result = "";
                    break;
            }
            return result;
        }

        internal static string Fact(int n)
        {            
            return Factorial.FactCount(n).ToString();           
        }

        internal static string StrSrch(string source)
        {
            return StringSearch.StrSearch(source);           
        }

        internal static bool Seq(string src)
        {
            return Sequence.Check(src);
        }
    }
}
