using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class Coffee : CaffeineBeverageBase
    {
        public Coffee(string beverageName = "Coffee") : base(beverageName)
        {
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and cream...");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing the coffee grounds...");
        }

      
     
    }
}
