using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public abstract class PizzaStore
    {
        public IPizza OrderPizza(PizzaTypeEnum type)
        {
            IPizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract IPizza CreatePizza(PizzaTypeEnum type);
    }
}
