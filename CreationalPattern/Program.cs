using System;

namespace CreationalPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Singleton Example:");
            SingletonExample.Run();
            Console.WriteLine();

            Console.WriteLine("Running Factory Method Example:");
            FactoryMethodExample.Run();
            Console.WriteLine();
        }
    }
}
