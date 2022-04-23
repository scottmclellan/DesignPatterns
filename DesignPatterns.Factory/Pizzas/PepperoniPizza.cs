using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class PepperoniPizza : PizzaBase
    {

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory, typeof(PepperoniPizza).Name) { }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Style} Style - {Name}");
            Console.WriteLine($"Tossing {ingredientFactory.CreateDough()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateSauce()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateCheese()}... ");
            Console.WriteLine($"Adding {ingredientFactory.CreatePepperoni()}... ");
        }

    }
}

