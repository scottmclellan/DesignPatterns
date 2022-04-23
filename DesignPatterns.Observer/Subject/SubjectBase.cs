using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public abstract class SubjectBase : ISubject
    {
        protected  List<IObserver> _observers = new List<IObserver>();
        public void UnregisterObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public abstract void NotifyObservers();
       
    }
}
