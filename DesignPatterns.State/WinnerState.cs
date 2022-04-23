using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class WinnerState : GumballStateBase, IGumballState
    {
        public WinnerState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }
        public void Dispense()
        {
            ReleaseGumball();
            if (!HasGumballs)
                ChangeStateSoldOut();
            else
            {
                ReleaseGumball();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter!");
                if (HasGumballs)
                    ChangeStateNoQuarter();
                else
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
    }
}
