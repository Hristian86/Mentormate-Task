using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    class FirstEngine
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
                    }
                    else
                    {
                        moduleConstrunctor += minus;
                    }
                }

                figures[i] += moduleConstrunctor;

                moduleConstrunctor = ""; //clearing string
            }

        }
    }
}