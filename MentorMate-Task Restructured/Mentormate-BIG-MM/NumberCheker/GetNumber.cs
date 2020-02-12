using System;
using System.Collections.Generic;
using System.Text;

namespace NumberCheker
{
    public class GetNumber
    {
        static Action<string> printMultyRow = message => Console.WriteLine(message);

        static Action<string> printOneRow = message => Console.Write(message);

        public static int GetN()
        {
            string mmLogo = "Enter the length of the Logo => ";

            string errorMessage = "";

            printOneRow(mmLogo);

            string input = Console.ReadLine();

            int num = 0;

            while (true)
            {
                bool isNumber = int.TryParse(input, out num);
                if (!isNumber)
                {
                    errorMessage = "Length must be a number!";

                    printMultyRow(errorMessage);

                    printOneRow(mmLogo);

                    input = Console.ReadLine();
                }
                else
                {

                    if (num > 2 && num < 10000)
                    {

                        if (num % 2 == 1)
                        {
                            break;
                        }
                        else
                        {
                            errorMessage = "Length must be odd number!";

                            printMultyRow(errorMessage);

                            printOneRow(mmLogo);

                            input = Console.ReadLine();
                        }
                    }
                    else
                    {
                        errorMessage = "Lenght must be between 2 and 10000";

                        printMultyRow(errorMessage);

                        printOneRow(mmLogo);

                        input = Console.ReadLine();
                    }
                }
            }

            return num;
        }
    }
}