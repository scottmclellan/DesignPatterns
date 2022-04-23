using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class Tea : CaffeineBeverageBase
    {
        public Tea(string beverageName = "Tea") : base(beverageName)
        {
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding lemon...");
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing the tea leaves...");
        }

    }
}
