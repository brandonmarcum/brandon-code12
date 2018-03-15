using System;
using System.Collections.Generic;
using ClassLibrary1;
using System.Linq;

namespace ShapeWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            //Shape shape = new Shape();
            Class1 class1 = new Class1();
            //Console.WriteLine(shape.hello);
            //shape.SetHello("12346");
            GC.Collect(3,GCCollectionMode.Forced);
            
            PlayWithRectangle();

            Console.ReadKey();
        }

        static void PlayWithRectangle()
        {
            var r = new Rectangle();
            var r1 = new Rectangle();
            //var s = new Shape();
            var sq = new Square();
            
            //s = r;

            //Console.WriteLine(s.Edges);
            Console.WriteLine(r.Edges);
        }

        static void PlayWithShapes()
        {
            Shape[] arrShapes1 = new Shape[10];
            //var arrShapes2 = new Shape[] { new Rectangle(), new Square(), new Triangle() };

            List<Shape> lasShapes1 = new List<Shape>();
            lasShapes1.ElementAt(8);
        }
    }
}
