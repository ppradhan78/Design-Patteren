using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = new Pizza();
            IPizza cheesDecorator = new CheesDecorator(pizza);
            IPizza tomatoDecorator = new TomatoDecorator(cheesDecorator);
            IPizza onionDecorator = new OnionDecorator(tomatoDecorator);
            Console.WriteLine(onionDecorator.GetIPizzaType());
            Console.ReadKey();
        }
        //Base Interface
        interface IPizza
        {
            string GetIPizzaType();
        }
        //concrete implementation
        class Pizza : IPizza
        {
            public string GetIPizzaType()
            {
                return "Normal Pizza";
            }
        }
        //Base Decorato
        class PizzaDecorator : IPizza
        {
            private IPizza _pizza;
            public PizzaDecorator(IPizza pizza)
            {
                _pizza = pizza;
            }
            public virtual string GetIPizzaType()
            {
                return _pizza.GetIPizzaType();
            }
        }
        //concrete Decorato
        class CheesDecorator : PizzaDecorator
        {
            public CheesDecorator(IPizza pizza) : base(pizza)
            {
            }
            public override string GetIPizzaType()
            {
                return base.GetIPizzaType() + "\r\n with extra  Chees";
            }
        }
        //concrete Decorato
        class TomatoDecorator : PizzaDecorator
        {
            public TomatoDecorator(IPizza pizza) : base(pizza)
            {
            }
            public override string GetIPizzaType()
            {
                return base.GetIPizzaType() + "\r\n with extra  Tomato";
            }
        }
        //concrete Decorato
        class OnionDecorator : PizzaDecorator
        {
            public OnionDecorator(IPizza pizza) : base(pizza)
            {
            }
            public override string GetIPizzaType()
            {
                return base.GetIPizzaType() + "\r\n with extra  Onion";
            }
        }
    }
}
