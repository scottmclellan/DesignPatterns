using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class CoffeeWithHook : CaffeineBeverageWithHookBase
    {
        public CoffeeWithHook(string beverageName = "Coffee") : base(beverageName)
        {
        }

        protected override void Brew()
        {
            Console.WriteLine("Brewing the coffee grounds...");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("Adding the sugar and cream...");
        }

        protected override bool ShouldAddCondiments()
        {
            return base.AskUserYesOrNo("Would you like sugar and cream added?");
        }

    }
}
