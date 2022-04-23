using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public  class ClamsPizza : PizzaBase
    {

        public ClamsPizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory, typeof(ClamsPizza).Name) { }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Style} Style - {Name}");
            Console.WriteLine($"Tossing {ingredientFactory.CreateDough()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateSauce()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateCheese()}... ");
            Console.WriteLine($"Adding {ingredientFactory.CreateClams()}... ");
        }

    }
}
