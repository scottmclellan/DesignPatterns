using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class NYStyleIngredientFactory : IPizzaIngredientFactory
    {
        public string Style => "New York";
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>()
           {
               new Spinach(),
               new Mushroom(),
               new Onion(),
               new GreeenPepper()
           };
        }
    }
}
