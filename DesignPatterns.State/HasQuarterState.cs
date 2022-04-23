using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.State
{
    public class HasQuarterState : GumballStateBase, IGumballState
    {
       private  Random _random = new Random(DateTime.Now.Millisecond);

        public HasQuarterState(GumballMachine gumballMachine) : base(gumballMachine)
        {
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Ejecting quarter");
            ChangeStateNoQuarter();
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Sorry already inserted a quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            
            int winner = _random.Next(10);

            if (winner == 0 && HasGumballs)
                ChangeStateWinner();
            else
                ChangeStateSold();
        }

      
    }
}
