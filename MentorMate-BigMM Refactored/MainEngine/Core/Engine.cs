using System;
using System.Collections.Generic;
using System.Text;
using MainEngine.Interfaces;

namespace MainEngine.Core
{
    public class Engine : IDrawable
    {
        //contains symbols and arrays for structure
        private string[] figures;
        //Buffer
        private string[] temp;
        private List<string> toBeDisplayed = new List<string>();
        private string star = "*";
        private string minus = "-";
        private int number;

        public Engine(int num)
        {
            this.figures = new string[num + 1];
            this.temp = new string[num + 1];
            this.number = num;
        }

        public int Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                this.number = value;
            }
        }

        //Encapsulating
        public IReadOnlyList<string> Run()
        {
            EngineRun();
            return this.toBeDisplayed.AsReadOnly();
        }

        private void EngineRun()
        {
            EngineCore engine = new EngineCore();

            engine.FirstModule(number, star, minus, figures);

            engine.SecondModule(number, star, minus, figures);

            // thirdModule is reversed second one:
            engine.SecondModule(number, star, minus, temp);

            ReverseArrayEng();

            //fourthModule is the second one reusing code:
            engine.SecondModule(number, star, minus, figures);

            //fifthModule is the first one reversed reusing code:
            engine.FirstModule(number, minus, star, temp);

            ReverseArrayEng();

            FilingList();
        }

        private void FilingList()
        {
            string bufferList = "";
            for (int i = 0; i < figures.Length; i++)
            {
                bufferList += figures[i] + figures[i];
                toBeDisplayed.Add(bufferList);
                bufferList = "";
            }
        }

        private void ReverseArrayEng()
        {

            int reverseArray = figures.Length - 1;

            for (int d = 0; d < figures.Length; d++)
            {
                figures[d] += temp[reverseArray];
                reverseArray--;
            }

            Array.Clear(temp, 0, figures.Length);
        }
    }
}