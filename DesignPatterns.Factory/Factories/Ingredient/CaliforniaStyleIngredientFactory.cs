using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class CaliforniaStyleIngredientFactory : IPizzaIngredientFactory
    {

        public string Style => "California";
        public Cheese CreateCheese()
        {
            return new NonDairyCheese();
        }

        public Clams CreateClams()
        {
            return new VeganClams();
        }

        public Dough CreateDough()
        {
            return new GlutenFreeDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new VeganPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new OrganicTomatoSauce();
        }

        public List<Veggie> CreateVeggies()
        {
            return new List<Veggie>()
           {
               new Mushroom(),
               new Onion(),
               new GreeenPepper(),
               new Eggplant(),
               new Spinach()
           };
        }
    }
}
