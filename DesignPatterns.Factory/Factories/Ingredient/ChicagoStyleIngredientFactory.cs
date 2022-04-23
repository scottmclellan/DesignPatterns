using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class ChicagoStyleIngredientFactory : IPizzaIngredientFactory
    {
        public string Style => "Chicago";
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>()
            {
                new Onion(),
                new Mushroom(),
                new GreeenPepper()
            };
        }
    }
}
