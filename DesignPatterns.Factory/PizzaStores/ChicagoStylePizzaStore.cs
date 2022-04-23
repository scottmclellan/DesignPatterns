using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override IPizza CreatePizza(PizzaTypeEnum type)
        {
            ChicagoStyleIngredientFactory factory = new ChicagoStyleIngredientFactory();


            switch (type)
            {
                case PizzaTypeEnum.Cheese:
                    return new CheesePizza(factory);
                case PizzaTypeEnum.Pepperoni:
                    return new PepperoniPizza(factory);
                case PizzaTypeEnum.Clam:
                    return new ClamsPizza(factory);
                case PizzaTypeEnum.Veggie:
                    return new VeggiePizza(factory);
                default:
                    return null;
            }
        }
    }
}
