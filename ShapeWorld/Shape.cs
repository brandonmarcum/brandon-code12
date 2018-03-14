using System;
using si = System.String;
using System.Collections.Generic;
using System.Text;

namespace ShapeWorld
{
    class Shape
    {

        //fields
        public string hello = "hello";
        private int _edge = 1;

        //properties
        public int Edge
        {
            get
            {
                return _edge;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _edge = value;
            }
        }
        public string Hello { get; set; }
        //constructors
        private Shape()
        {
            //common setup
            hello = "shape";
            Hello = "shape-shifter";
        }
        public Shape(int sides) : this()
        {
            Edge = sides;
        }

        //destructors
        //methods
        public void SetHello(string h)
        {
            hello = h;
        }
    }
}
