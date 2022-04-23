using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class QuackCounter : IQuackable
    {
        private readonly IQuackable _quackable;
        private static int numberOfQuacks;
        public QuackCounter(IQuackable quackable)
        {
            this._quackable = quackable;
        }

        public void Quack()
        {
            _quackable.Quack();
            numberOfQuacks++;
        }

        public static int GetQuacks() => numberOfQuacks;

        public void RegisterObserver(IObserver observer)
        {
            _quackable.RegisterObserver(observer);
        }

        public void NotifyObserver()
        {
            _quackable.NotifyObserver();
        }
    }
}
