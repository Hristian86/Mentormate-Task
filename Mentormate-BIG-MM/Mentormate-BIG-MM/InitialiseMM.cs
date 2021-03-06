﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mentormate_BIG_MM
{
    public class InitialiseMM
    {
        public static void Initialise()
        {
            // try catch to be seted
            int number = 0;

            number = Adapter.GetNumber();


            string[] figures = new string[number + 1];// main storage

            string[] temp = new string[number + 1];// temporary storage for reverse function

            string star = "*";
            string minus = "-";


            MainEngine.FirstModule(number, star, minus, figures);

            MainEngine.SecondModule(number, star, minus, figures);

            // thirdModule is reversed second one
            MainEngine.SecondModule(number, star, minus, temp);

            int reverseArray = figures.Length - 1;

            for (int d = 0; d < figures.Length; d++)
            {
                figures[d] += temp[reverseArray];
                reverseArray--;
            }

            Array.Clear(temp, 0, temp.Length);

            //fourthModule is the second one reusing code
            MainEngine.SecondModule(number, star, minus, figures);

            //fifthModule is the first one reversed reusing code
            MainEngine.FirstModule(number, minus, star, temp);

            reverseArray = figures.Length - 1;

            for (int i = 0; i < figures.Length; i++)
            {
                figures[i] += temp[reverseArray];
                reverseArray--;
            }

            string finalPorduct = "";

            for (int i = 0; i < figures.Length; i++)
            {
                finalPorduct += figures[i] + figures[i] + Environment.NewLine;
            }

            Adapter.Print(finalPorduct);
        }
    }
}