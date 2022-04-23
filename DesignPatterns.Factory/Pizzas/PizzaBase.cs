using System;
using System.Collections.Generic;
using DesignPatterns.Common;
using System.Text;

namespace DesignPatterns.Factory
{
    public abstract class PizzaBase : IPizza
    {
     

        private string _name;

        public string Name
        {
            get { return _name.FormatCamelCaseString(); }
            private set { _name = value; }
        }

        protected IPizzaIngredientFactory ingredientFactory;
        protected Dough dough;
        protected Sauce sauce;
        protected Cheese cheese;
        protected Pepperoni pepperoni;
        protected Clams clams;
        protected List<Veggie> veggies;
        
        protected string Style => ingredientFactory.Style;

        public PizzaBase(IPizzaIngredientFactory pizzaIngredientFactory, string pizzaName)
        {
            ingredientFactory = pizzaIngredientFactory;
            Name = pizzaName;
        }

        public abstract void Prepare();

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza in diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }       
     
    }
}
