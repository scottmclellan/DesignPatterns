using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class SoldState : GumballStateBase, IGumballState
    {
        public SoldState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }
        public void Dispense()
        {
            ReleaseGumball();

            if(HasGumballs)
            {
                ChangeStateNoQuarter();
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");

                ChangeStateSoldOut();
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry already turned the crank...");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, working on dispensing a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball!");
        }

        public override string ToString()
        {
            return "Dispensing a gumball";
        }
    }
}
