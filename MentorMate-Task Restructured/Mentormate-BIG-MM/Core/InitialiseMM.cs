using System;
using System.Collections.Generic;
using System.Text;
using ReversingEngine;
using OutputWriter;
using NumberCheker;
using Engine;
using Data;
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

            //object contains symbols and arrays for structure
            Storage figures = new Storage(number);
           
            FirstEngine.FirstModule(number, figures.Star, figures.Minus, figures.GetFigures());

            SecondEngine.SecondModule(number, figures.Star, figures.Minus, figures.GetFigures());

            // thirdModule is reversed second one:
            SecondEngine.SecondModule(number, figures.Star, figures.Minus, figures.GetTemp());

            ReverseArray.ReverseArrayEng(figures.GetFigures(), figures.GetTemp());

            //fourthModule is the second one reusing code:
            SecondEngine.SecondModule(number, figures.Star, figures.Minus, figures.GetFigures());

            //fifthModule is the first one reversed reusing code:
            FirstEngine.FirstModule(number, figures.Minus, figures.Star, figures.GetTemp());

            ReverseArray.ReverseArrayEng(figures.GetFigures(), figures.GetTemp());

            Display.Print(ConvertToString.ConvertStr(figures.GetFigures()));
        }
    }
}