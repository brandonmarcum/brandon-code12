using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Rectangle : Shape
    {
        public virtual decimal Length { get; set; }
        public virtual decimal Width { get; set; }
        public new int Edges { get; set; }

        public decimal Area()
        {
            return Length * Width;
        }

        public Rectangle() : base(4)
        {
        }

        public override decimal Perimeter()
        {
            return (2 * Length) + (2 * Width);
        }

        public override decimal Volume()
        {
            throw new NotImplementedException();
        }
    }
}
