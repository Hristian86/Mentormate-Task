using System;
using System.Collections.Generic;
using System.Text;

namespace RefranceStorage
{
    public class ArrayStorage
    {
        string[] figure;
        public ArrayStorage(int number)
        {
            this.figure = new string[number + 1];
        }

        public string[] GetArray()
        {
            return this.figure;
        }
    }
}