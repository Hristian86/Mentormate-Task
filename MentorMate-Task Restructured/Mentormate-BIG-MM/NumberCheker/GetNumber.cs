using System;
using System.Collections.Generic;
using System.Text;
using OutputWriter;
using InputReader;

namespace NumberCheker
{
    public class GetNumber
    {
        public static int GetN()
        {
            string mmLogo = "Enter the length of the Logo N=> ";

            string errorMessage = "";

            Display.Print(mmLogo);

            string input = InputRead.GetInput();

            int num = 0;

            while (true)
            {
                bool isNumber = int.TryParse(input, out num);

                if (!isNumber)
                {
                    errorMessage = "Length must be a number!";

                    Display.PrintNewLine(errorMessage);

                    Display.Print(mmLogo);

                    input = InputRead.GetInput();
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

                            Display.PrintNewLine(errorMessage);

                            Display.Print(mmLogo);

                            input = InputRead.GetInput();
                        }
                    }
                    else
                    {
                        errorMessage = "Lenght must be between 2 and 10000";

                        Display.PrintNewLine(errorMessage);

                        Display.Print(mmLogo);

                        input = InputRead.GetInput();
                    }
                }
            }

            return num;
        }
    }
}