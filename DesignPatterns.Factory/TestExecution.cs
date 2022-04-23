using DesignPatterns.Common;
using System;

namespace DesignPatterns.Factory
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            PizzaStore pizzaStore = new NYStylePizzaStore();

            Console.WriteLine("*** Order 1 - NY Style Cheese ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Cheese);
            Console.WriteLine();

            Console.WriteLine("*** Order 2 - NY Style Pepperoni ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Pepperoni);
            Console.WriteLine();

            Console.WriteLine("*** Order 3 - NY Style Clam ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Clam);
            Console.WriteLine();

            Console.WriteLine("*** Order 4 - NY Style Veggie ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Veggie);
            Console.WriteLine();

            pizzaStore = new ChicagoStylePizzaStore();

            Console.WriteLine("*** Order 5 - Chicago Style Cheese ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Cheese);
            Console.WriteLine();

            Console.WriteLine("*** Order 6 - Chicago Style Pepperoni ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Pepperoni);
            Console.WriteLine();

            Console.WriteLine("*** Order 7 - Chicago Style Clam ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Clam);
            Console.WriteLine();

            Console.WriteLine("*** Order 8 - Chicago Style Veggie ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Veggie);
            Console.WriteLine();

            pizzaStore = new CaliforniaStylePizzaStore();

            Console.WriteLine("*** Order 9 - California Style Cheese ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Cheese);
            Console.WriteLine();

            Console.WriteLine("*** Order 10 - California Style Pepperoni ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Pepperoni);
            Console.WriteLine();

            Console.WriteLine("*** Order 11 - California Style Clam ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Clam);
            Console.WriteLine();

            Console.WriteLine("*** Order 12 - California Style Veggie ***");
            pizzaStore.OrderPizza(PizzaTypeEnum.Veggie);
            Console.WriteLine();
        }
    }
}
