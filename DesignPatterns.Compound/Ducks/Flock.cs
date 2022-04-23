using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class Flock :  IQuackable
    {
        private List<IQuackable> _quackables = new List<IQuackable>();

        public void Quack() => _quackables.ForEach(quackable => quackable.Quack());

        public void Add(params IQuackable[] quackable)
        {
            _quackables.AddRange(quackable);
        }

        public void RegisterObserver(IObserver observer)
        {
            _quackables.ForEach(x => x.RegisterObserver(observer));
        }

        public void NotifyObserver()
        {
            _quackables.ForEach(x => x.NotifyObserver());
        }       
    }
}
