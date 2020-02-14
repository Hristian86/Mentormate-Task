using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class Storage : CoreAttributes
    {
        private string[] figures;
        private string[] temp;

        public Storage(int number)
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
    }
}