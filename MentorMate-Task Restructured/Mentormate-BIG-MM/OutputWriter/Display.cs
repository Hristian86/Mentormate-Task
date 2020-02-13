using System;
using System.Collections.Generic;
using System.Text;

namespace OutputWriter
{
    public class Display
    {
        static Action<string> printOneRow = message => Console.Write(message);

        static Action<string> printMultyRow = message => Console.WriteLine(message);

        public static void PrintNewLine(string display)
        {
            printMultyRow(display);
        }

        public static void Print(string display)
        {
            printOneRow(display);
        }
    }
}