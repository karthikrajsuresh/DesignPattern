using System;

namespace BehavioralPattern
{
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyA execution.");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("ConcreteStrategyB execution.");
        }
    }

    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            _strategy.Execute();
        }
    }

    public class StrategyExample
    {
        public static void Run()
        {
            Context context = new Context(new ConcreteStrategyA());
            context.ExecuteStrategy();

            context.SetStrategy(new ConcreteStrategyB());
            context.ExecuteStrategy();
        }
    }
}
