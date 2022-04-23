using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class SoldOutState : GumballStateBase, IGumballState
    {
        public SoldOutState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }
        public void Dispense()
        {
            Console.WriteLine("Sorry machine is empty");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry machine is empty");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sorry machine is empty");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Sorry machine is empty");
        }

        public override void AddGumballs(int count)
        {
            base.AddGumballs(count);

            if(HasGumballs)
                ChangeStateNoQuarter();
        }

        public override string ToString()
        {
            return "Sold out of gumballs";
        }
    }
}
