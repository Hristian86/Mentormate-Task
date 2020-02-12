using System;
using System.Collections.Generic;
using System.Text;
using ReversingEngine;
using Output;
using NumberCheker;
using Engine;
using RefranceStorage;

namespace Drawable
{
    public class InitialiseMM
    {
        public static void Initialise()
        {
            // try catch to be seted
            int number = 0;

            number = GetNumber.GetN();
            
            ArrayStorage figures = new ArrayStorage(number);

            TemporaryArray temp = new TemporaryArray(number);

            string star = "*";
            string minus = "-";

            FirstEngine.FirstModule(number, star, minus, figures.GetArray());

            SecondEngine.SecondModule(number, star, minus, figures.GetArray());

            // thirdModule is reversed second one:
            SecondEngine.SecondModule(number, star, minus, temp.GetArray());

            ReverseArray.ReverseArrayEng(figures.GetArray(), temp.GetArray());

            //fourthModule is the second one reusing code:
            SecondEngine.SecondModule(number, star, minus, figures.GetArray());

            //fifthModule is the first one reversed reusing code:
            FirstEngine.FirstModule(number, minus, star, temp.GetArray());

            ReverseArray.ReverseArrayEng(figures.GetArray(), temp.GetArray());

            Display.Print(ConvertToString.ConvertStr(figures.GetArray()));
        }
    }
}