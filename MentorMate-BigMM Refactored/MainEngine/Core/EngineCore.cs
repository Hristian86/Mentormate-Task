﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MainEngine.Core
{
    internal class EngineCore
    {
        public void FirstModule(int number, string star, string minus, string[] figures)
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

        public void SecondModule(int number, string star, string minus, string[] figures)
        {
            //structure variables
            string moduleConstrunctor = "";

            int halfOfNumber = number / 2 + 1;

            int insideMinuse = 1;

            int lineStars = number / 2;

            //row
            for (int i = 0; i <= number; i++)
            {
                //col
                for (int j = number; j >= 1; j--)
                {

                    if (j <= i)
                    {

                        if (i >= halfOfNumber) //  other half with mix stars and minuses
                        {

                            if (j == halfOfNumber) // when it reaches the verticaly simetric
                            {

                                for (int s = 0; s < insideMinuse; s++) // middle minuses
                                {
                                    moduleConstrunctor += minus;
                                }

                                insideMinuse += 2; // incresed count for middle minuses

                                for (int f = lineStars; f > 0; f--) // stars at the last lines
                                {
                                    moduleConstrunctor += star;
                                }

                                lineStars--; // decreasing side lines of stars

                            }

                        }
                        else
                        {
                            moduleConstrunctor += star; //upper stars
                        }

                    }
                    else
                    {
                        moduleConstrunctor += star; // upper stars
                    }

                }

                figures[i] += moduleConstrunctor;

                moduleConstrunctor = ""; // clearing string
            }

        }
    }
}