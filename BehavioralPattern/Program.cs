using System;

namespace BehavioralPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Observer Example:");
            ObserverExample.Run();
            Console.WriteLine();

            Console.WriteLine("Running Strategy Example:");
            StrategyExample.Run();
            Console.WriteLine();
        }
    }
}
