using System;

namespace StructuralPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Adapter Example:");
            AdapterExample.Run();
            Console.WriteLine();

            Console.WriteLine("Running Decorator Example:");
            DecoratorExample.Run();
            Console.WriteLine();
        }
    }
}
