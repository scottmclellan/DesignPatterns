using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class VeggiePizza : PizzaBase
    {

        public VeggiePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory, typeof(VeggiePizza).Name) { }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Style} Style - {Name}");
            Console.WriteLine($"Tossing {ingredientFactory.CreateDough()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateSauce()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateCheese()}... ");
            Console.WriteLine($"Adding Veggies:");

            foreach(var veggie in ingredientFactory.CreateVeggies())
            {
                Console.WriteLine($"\t {veggie.Name}");
            }
        }

    }
}

