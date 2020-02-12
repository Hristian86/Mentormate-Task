using System;
using System.Collections.Generic;
using System.Text;

namespace RefranceStorage
{
    public class TemporaryArray
    {
        string[] temp;
        public TemporaryArray(int number)
        {
            temp = new string[number + 1];
        }

        public string[] GetArray()
        {
            return this.temp;
        }
    }
}
