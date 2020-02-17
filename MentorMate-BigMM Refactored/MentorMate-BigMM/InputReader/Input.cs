using System;
using System.Collections.Generic;
using System.Text;
using Interfaces;

namespace InputReader
{
    public class Input : IReadable
    {
        static Action<string> printMultiRow = message => Console.WriteLine(message);

        static Action<string> printOneRow = message => Console.Write(message);

        public int GetNumber()
        {
            int num = CheckNumber();
            return num;
        }

        private int CheckNumber()
        {
            string mmLogo = "Enter the length of the Logo => ";

            string errorMessagе = "";

            printOneRow(mmLogo);

            string input = Console.ReadLine();

            int num = 0;

            while (true)
            {
                bool isNumber = int.TryParse(input, out num);
                if (!isNumber)
                {
                    errorMessagе = "Length must be a number!";

                    printMultiRow(errorMessagе);

                    printOneRow(mmLogo);

                    input = Console.ReadLine();
                }
                else
                {

                    if (num >= 3 && num <= 10000)
                    {

                        if (num % 2 == 1)
                        {
                            break;
                        }
                        else
                        {
                            errorMessagе = "Length must be odd number!";
                            printMultiRow(errorMessagе);

                            printOneRow(mmLogo);

                            input = Console.ReadLine();
                        }
                    }
                    else
                    {
                        errorMessagе = "Lenght must be from 3 to 10000";

                        printMultiRow(errorMessagе);

                        printOneRow(mmLogo);

                        input = Console.ReadLine();
                    }
                }
            }
            return num;
        }
    }
}
