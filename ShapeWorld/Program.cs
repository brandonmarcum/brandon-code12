using System;

namespace ShapeWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            Shape shape = new Shape();
            Console.WriteLine(shape.hello);

            Console.ReadKey();
        }
    }
}
