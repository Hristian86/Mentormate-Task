using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Output
{
    public class ConvertToString
    {
        public static string ConvertStr(string[] figures)
        {
            string finalPorduct = "";

            for (int i = 0; i < figures.Length; i++)
            {

                finalPorduct += figures[i] + figures[i] + Environment.NewLine;
            }

            return finalPorduct;
        }
    }
}