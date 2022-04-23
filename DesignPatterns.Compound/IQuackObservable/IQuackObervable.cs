using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObserver();
    }
}
