using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public class CheesePizza : PizzaBase
    {

        public CheesePizza(IPizzaIngredientFactory ingredientFactory) : base(ingredientFactory, typeof(CheesePizza).Name) { }
            
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Style} Style - {Name}");
            Console.WriteLine($"Tossing {ingredientFactory.CreateDough()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateSauce()}...");
            Console.WriteLine($"Adding {ingredientFactory.CreateCheese()}... ");          
        }      
     
    }
}
