using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Template
{
    public abstract class CaffeineBeverageWithHookBase
    {
        private string _beverageName;
        protected CaffeineBeverageWithHookBase(string beverageName)
        {
            _beverageName = beverageName;
        }

        public void PrepareRecipe()
        {
            Console.WriteLine($"Preparing {_beverageName}");

            BoilWater();

            Brew();

            PourIntoCup();          

            if(ShouldAddCondiments())
                AddCondiments();
        }

       

        private void BoilWater()
        {
            Console.WriteLine("Boiling water...");
        }


        private void PourIntoCup()
        {
            Console.WriteLine("Pouring into cup...");
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        protected virtual bool ShouldAddCondiments()
        {
            return true;
        }
        
        protected bool AskUserYesOrNo(string message)
        {
            Console.WriteLine($"{message} (Y/N)");
            var response = Console.ReadLine();

            return response != null && response.ToUpper() == "Y";
        }

    }
}
