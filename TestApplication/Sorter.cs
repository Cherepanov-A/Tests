using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;

namespace TestApplication
{
    public class Sorter
    {
        internal static int[] IntSort(int[] intArr)
        {
            if (intArr.Length < 2)
            {
                throw new ArgumentException("Array length is under 2");
            }
            else
            {
                bool done = true;
                while (done)
                {
                    done = false;
                    for (int i = 1; i < intArr.Length; i++)
                    {

                        if (intArr[i] < intArr[i - 1])
                        {
                            int temp = intArr[i];
                            intArr[i] = intArr[i - 1];
                            intArr[i - 1] = temp;
                            done = true;
                        }
                    }
                }
            }
            return intArr;
        }
        public static int Search(int[] sortArr, int number)
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


    }
}