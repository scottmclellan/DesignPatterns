using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Factory
{
    public interface IPizzaIngredientFactory
    {
        string Style { get; }
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
        List<Veggie> CreateVeggies();
    }
}
