using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class Quackologist : IObserver
    {
        public void Update(IQuackObservable duck)
        {
            Console.WriteLine($"Quackologist {duck} just quacked.");
        }
    }
}
