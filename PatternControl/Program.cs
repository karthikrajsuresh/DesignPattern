using System;

namespace PatternControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the pattern to run:");
            Console.WriteLine("1. Creational Pattern - Singleton");
            Console.WriteLine("2. Creational Pattern - Factory Method");
            Console.WriteLine("3. Structural Pattern - Adapter");
            Console.WriteLine("4. Structural Pattern - Decorator");
            Console.WriteLine("5. Behavioral Pattern - Observer");
            Console.WriteLine("6. Behavioral Pattern - Strategy");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreationalPattern.SingletonExample.Run();
                    break;
                case "2":
                    CreationalPattern.FactoryMethodExample.Run();
                    break;
                case "3":
                    StructuralPattern.AdapterExample.Run();
                    break;
                case "4":
                    StructuralPattern.DecoratorExample.Run();
                    break;
                case "5":
                    BehavioralPattern.ObserverExample.Run();
                    break;
                case "6":
                    BehavioralPattern.StrategyExample.Run();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
