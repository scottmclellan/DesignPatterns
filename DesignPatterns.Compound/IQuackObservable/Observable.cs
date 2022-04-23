using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class Observable : IQuackObservable
    {
        private List<IObserver> _observers = new List<IObserver>();
        IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void NotifyObserver()
        {
            foreach(var observer in _observers)
            {
                observer.Update(_duck);
            }
        }
    }
}
