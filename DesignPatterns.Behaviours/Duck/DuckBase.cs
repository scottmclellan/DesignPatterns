using DesignPatterns.Behaviours.Fly;
using DesignPatterns.Behaviours.Quack;
using DesignPatterns.Behaviours.Duck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behaviours.Duck
{
    public abstract class DuckBase : IDuck
    {

        public DuckBase(IQuackBehavior quackBehavior, IFlyBehavior flyBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;

        }

        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public void Fly()
        {
            FlyBehavior.Fly();
        }

        public void Quack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("We be swimming");
        }

        public abstract void About();
        
    }
}
