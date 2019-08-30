using System;

namespace TestApplication
{
    public class Sorter
    {
        public static int[] IntSort(int[] intArr)
        {
            if (intArr.Length < 2)
            {
                throw new ArgumentException("Array length is under 2");
            }
            else
            {
                for (int i = 1; i < intArr.Length; i++)
                {
                    if (intArr[i] < intArr[i - 1])
                    {
                        int temp = intArr[i];
                        intArr[i] = intArr[i - 1];
                        intArr[i - 1] = temp;
                    }
                }
            }
            return intArr;
        }
    }
}