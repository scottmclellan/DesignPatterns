using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class NoQuarterState : GumballStateBase, IGumballState
    {
        public NoQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            ChangeStateHasQuarter();
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter.");
        }
    }
}
