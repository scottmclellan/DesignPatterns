using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public class TeaWithHook : CaffeineBeverageWithHookBase
    {
        public TeaWithHook(string beverageName = "Tea") : base(beverageName)
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

        protected override bool ShouldAddCondiments()
        {
            return base.AskUserYesOrNo("Would you like lemon added to your tea?");
        }

    }
}
