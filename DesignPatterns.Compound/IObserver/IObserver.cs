using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public interface IObserver
    {
        void Update(IQuackObservable duck);
    }
}
