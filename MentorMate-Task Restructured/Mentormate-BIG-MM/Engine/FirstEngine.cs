using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class FirstEngine
    {
        public static void FirstModule(int number, string star, string minus, string[] figures)
        {
            string moduleConstrunctor = "";

            //row
            for (int i = 0; i <= number; i++)
            {
                //col
                for (int s = number; s >= 1; s--)
                {
                    if (s <= i) // border betwean stars and minuses
                    {
                        moduleConstrunctor += star;
                        //      Console.Write(star);
                    }
                    else
                    {
                        moduleConstrunctor += minus;
                        //      Console.Write(minus);
                    }
                }
                //Console.WriteLine();
                figures[i] += moduleConstrunctor;
                moduleConstrunctor = ""; //clearing string
            }

        }
    }
}