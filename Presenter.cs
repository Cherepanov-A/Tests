using System;

namespace TestApplication
{
    public class Presenter
    {
        public static string Sort(string arrTxt)
    {
        string[] temp = arrTxt.Split(' ');
        int[] inArr = new int[temp.Length];
        for (int i = 0; i < temp.Length; i++)
        {
            inArr[i] = Convert.ToInt32(temp[i]);
        }
        int[] result = Sorter.
    }
    }
}
