using System;
using si = System.String;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Shape : iShape, iForm
    {

        //properties
        public int Edges { get;}
        int iForm.Edges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        //constructors
        public Shape()
        {
            //common setup
            Edges = 10;
        }

        public Shape(int e)
        {
            //common setup
            Edges = e;
        }

        //destructors
        //methods

        int iForm.Area()
        {
            return 10;
        }

        public virtual decimal Area()
        {
            return 10;
        }

        public virtual decimal Perimeter()
        {
            return 10;
        }

        public abstract decimal Volume();
    }
}
