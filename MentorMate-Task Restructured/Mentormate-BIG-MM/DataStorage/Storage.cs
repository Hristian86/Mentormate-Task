using System;
using System.Collections.Generic;
using System.Text;

namespace DataStorage
{
    public class Storage : Attribute
    {
        private string[] figures;
        private string[] temp;

        private string star = "*";
        private string minus = "-";

        public Storage(int number) : base()
        {
            
            figures = new string[number + 1];
            temp = new string[number + 1];
        }

        public string[] GetFigures()
        {
            return this.figures;
        }

        public string[] GetTemp()
        {
            return this.temp;
        }

        public string Star
        {
            get
            {
                return this.star;
            }
        }

        public string Minus
        {
            get
            {
                return this.minus;
            }
        }
    }
}