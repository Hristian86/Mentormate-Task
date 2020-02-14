using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public abstract class CoreAttributes
    {
        private string star = "*";
        private string minus = "-";

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