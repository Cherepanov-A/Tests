using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication
{
    class Model
    {
        private int[] sortArr;
        internal string Check(string src)
        {
            string res = "";
            int a = 0;
            int b = 0;
            int c = 0;
            foreach (var item in src)
            {
                switch (item)
                {
                    case '(':
                        a++;
                        break;
                    case ')':
                        a++;
                        break;
                    case '{':
                        b++;
                        break;
                    case '}':
                        b++;
                        break;
                    case '[':
                        c++;
                        break;
                    case ']':
                        c++;
                        break;
                    default:
                        break;
                }
                if (a % 2 == 0 && b % 2 == 0 && c % 2 == 0)
                {
                    res = "Correct squence";
                }
                else
                {
                    res = "Incorrect squence";
                }
            }
            return res;
        }


        internal  string IntSort(string arrTxt)
        {
            string[] temp = arrTxt.Split(' ');
            if (temp.Length < 2)
            {
                return "This is not array";
            }
            List<int> unsortArr = new List<int>();
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] != "")
                {
                    unsortArr.Add(Convert.ToInt32(temp[i]));
                }
                
            }
            bool done = true;
            while (done)
            {
                done = false;
                for (int i = 1; i < unsortArr.Count; i++)
                {

                    if (unsortArr[i] < unsortArr[i - 1])
                    {
                        int buffer = unsortArr[i];
                        unsortArr[i] = unsortArr[i - 1];
                        unsortArr[i - 1] = buffer;
                        done = true;
                    }
                }
            }
            sortArr = new int[unsortArr.Count];
            for (int i = 0; i < sortArr.Length; i++)
            {
                sortArr[i] = unsortArr[i];
            }
            StringBuilder result = new StringBuilder();
            foreach (var item in unsortArr)
            {
                result.Append(item.ToString() + " ");
            }
            return result.ToString();
        }


        public  int Search(int number)
        {
            int right = sortArr.Length;
            int left = 0;
            int mid = 0;
            if (sortArr == null)
            {
                return 0;
            }
            if (number < sortArr[0] || number > sortArr[sortArr.Length - 1])
            {
                return -1;
            }
            else
            {
                while (left != right)
                {
                    mid = left + (right - left) / 2;
                    if (number == sortArr[mid])
                    {
                        return 1;
                    }
                    if (number < sortArr[mid])
                    {
                        right = mid;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                return -1;
            }
        }


        internal  string StrSearch(string input)
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


        internal  int FactCount(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }  


}


