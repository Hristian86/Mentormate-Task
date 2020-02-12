using System;
using System.Collections.Generic;
using System.Text;

namespace ReversingEngine
{
    public class ReverseArray
    {
        public static void ReverseArrayEng(string[] figures, string[] temp)
        {

            int reverseArray = figures.Length - 1;

            for (int d = 0; d < figures.Length; d++)
            {
                figures[d] += temp[reverseArray];
                reverseArray--;
            }

            Array.Clear(temp, 0, figures.Length);
        }
    }
}