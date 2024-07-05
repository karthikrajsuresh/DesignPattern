using System;

namespace StructuralPattern
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent operation.");
        }
    }

    public abstract class Decorator : Component
    {
        protected Component _component;

        public Decorator(Component component)
        {
            _component = component;
        }

        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA operation.");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component) { }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorB operation.");
        }
    }

    public class DecoratorExample
    {
        public static void Run()
        {
            Component component = new ConcreteComponent();
            component = new ConcreteDecoratorA(component);
            component = new ConcreteDecoratorB(component);
            component.Operation();
        }
    }
}
