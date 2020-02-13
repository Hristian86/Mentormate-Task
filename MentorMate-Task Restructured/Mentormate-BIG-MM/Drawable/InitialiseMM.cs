using System;
using System.Collections.Generic;
using System.Text;
using ReversingEngine;
using OutputWriter;
using NumberCheker;
using Engine;

namespace Drawable
{
    public class InitialiseMM
    {
        public static void Initialise()
        {
            // try catch to be seted
            int number = 0;

            number = GetNumber.GetN();

            string[] figures = new string[number + 1];// main storage

            string[] temp = new string[number + 1];// temporary storage for reverse function

            string star = "*";
            string minus = "-";

            FirstEngine.FirstModule(number, star, minus, figures);

            SecondEngine.SecondModule(number, star, minus, figures);

            // thirdModule is reversed second one:
            SecondEngine.SecondModule(number, star, minus, temp);

            ReverseArray.ReverseArrayEng(figures, temp);

            //fourthModule is the second one reusing code:
            SecondEngine.SecondModule(number, star, minus, figures);

            //fifthModule is the first one reversed reusing code:
            FirstEngine.FirstModule(number, minus, star, temp);

            ReverseArray.ReverseArrayEng(figures, temp);

            Display.Print(ConvertToString.ConvertStr(figures));
        }
    }
}