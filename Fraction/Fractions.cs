using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fractions
    {
        private int _den;
        public int Num { get; set; }
        public int Den
        {
            get
            {
                return _den;
            }
            set
            {
                if (value == 0) throw new ArgumentException("DEN should be  more then zero");
                _den = value;
            }
        }
        public Fractions()
        {
            Num = 0;
            Den = 1;
        }
        public Fractions(int numer, int denom)
        {
            Num = numer;
            Den = denom;
           
        }
    }
}
