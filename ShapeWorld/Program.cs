using System;

namespace ShapeWorld
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            

            Shape shape = new Shape(5);
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            Console.WriteLine(shape.hello);
            shape.SetHello("12346");
            shape.Hello = "50";
            Console.WriteLine(shape.Hello);
            GC.Collect(3,GCCollectionMode.Forced);


            Console.ReadKey();
        }
    }
}
