using System;
using System.Collections.Generic;
using System.Text;
using ReversingEngine;
using OutputWriter;
using NumberCheker;
using Engine;
using DataStorage;
using StringConvert;

namespace Core
{
    public class InitialiseMM
    {
        public static void Initialise()
        {
            // try catch to be seted
            int number = 0;

            number = GetNumber.GetN();

            Storage figures = new Storage(number);

            string star = "*";
            string minus = "-";

            FirstEngine.FirstModule(number, star, minus, figures.GetFigures());

            SecondEngine.SecondModule(number, star, minus, figures.GetFigures());

            // thirdModule is reversed second one:
            SecondEngine.SecondModule(number, star, minus, figures.GetTemp());

            ReverseArray.ReverseArrayEng(figures.GetFigures(), figures.GetTemp());

            //fourthModule is the second one reusing code:
            SecondEngine.SecondModule(number, star, minus, figures.GetFigures());

            //fifthModule is the first one reversed reusing code:
            FirstEngine.FirstModule(number, minus, star, figures.GetTemp());

            ReverseArray.ReverseArrayEng(figures.GetFigures(), figures.GetTemp());

            Display.Print(ConvertToString.ConvertStr(figures.GetFigures()));
        }
    }
}