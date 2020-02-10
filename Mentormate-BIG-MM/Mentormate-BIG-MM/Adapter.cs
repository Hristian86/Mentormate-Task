using System;
using System.Collections.Generic;
using System.Text;

namespace Mentormate_BIG_MM
{
    public class Adapter
    {
       static Action<string> printMultiRow = message => Console.WriteLine(message);

       static Action<string> printOneRow = message => Console.Write(message);

        public static int GetNumber()
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




        public static void Message()
        {
            Console.WriteLine("Length must be a number!");
            Console.Write("Enter the length of the Logo: ");
        }

        public static void Print(string display)
        {

            Console.WriteLine(display.Trim());

        }

    }
}