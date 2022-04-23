using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
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
