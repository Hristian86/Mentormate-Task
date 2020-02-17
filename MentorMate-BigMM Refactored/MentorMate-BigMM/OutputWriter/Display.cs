using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace OutputWriter
{
    public class Display : IWriteable
    {
        static Action<string> printOneRow = message => Console.Write(message);

        static Action<string> printMultyRow = message => Console.WriteLine(message);

        public void Print(IReadOnlyList<string> forOutput)
        {
            string display = ConvertToString(forOutput);
            printOneRow(display.Trim());
        }

        private string ConvertToString(IReadOnlyList<string> forOutputs)
        {
            string x = "";
            for (int i = 0; i < forOutputs.Count; i++)
            {
                x += forOutputs[i] + Environment.NewLine;
            }
            return x.Trim();
        }
    }
}