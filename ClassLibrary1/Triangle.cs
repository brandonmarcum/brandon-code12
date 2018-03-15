using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Triangle : Shape
    {
        private decimal _length;

        public Triangle() : base(3)
        {
        }
        public decimal Base { get; set; }
        public decimal Height { get; set; }

        public override decimal Volume()
        {
            throw new NotImplementedException();
        }
    }
}
