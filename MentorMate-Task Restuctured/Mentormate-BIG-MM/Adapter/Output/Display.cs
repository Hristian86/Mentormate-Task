using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Output
{
    public class Display
    {
        static Action<string> printOneRow = message => Console.Write(message);

        public static void Print(string display)
        {
            printOneRow(display.Trim());
        }
    }
}