using System;

namespace CreationalPattern
{
    public abstract class Product
    {
        public abstract void Operation();
    }

    public class ConcreteProductA : Product
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteProductA operation.");
        }
    }

    public class ConcreteProductB : Product
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteProductB operation.");
        }
    }

    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    public class ConcreteCreatorA : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductA();
        }
    }

    public class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProductB();
        }
    }

    public class FactoryMethodExample
    {
        public static void Run()
        {
            Creator creator = new ConcreteCreatorA();
            Product product = creator.FactoryMethod();
            product.Operation();

            creator = new ConcreteCreatorB();
            product = creator.FactoryMethod();
            product.Operation();
        }
    }
}
