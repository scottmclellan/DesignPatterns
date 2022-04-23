using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public interface IGumballState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
        void AddGumballs(int count);

    }
}
