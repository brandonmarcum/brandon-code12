using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Square : Rectangle
    {
        private decimal _length;

        public override decimal Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public override decimal Width
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;
            }
        }

        public override decimal Perimeter()
        {
            return (4 * Length);
        }

    }
}
