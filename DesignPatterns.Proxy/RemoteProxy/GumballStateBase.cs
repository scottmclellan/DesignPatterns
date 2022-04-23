using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
   public abstract class GumballStateBase
    {
        private readonly GumballMachine _gumballMachine;

        public GumballStateBase(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        protected void ChangeStateHasQuarter()
        {
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState());
        }

        protected void ChangeStateNoQuarter()
        {
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        protected void ChangeStateWinner()
        {
            _gumballMachine.SetState(_gumballMachine.GetWinnerState());
        }

        protected void ChangeStateSoldOut()
        {
            _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
        }

        protected void ChangeStateSold()
        {
            _gumballMachine.SetState(_gumballMachine.GetSoldState());
        }

        protected void ReleaseGumball()
        {
            _gumballMachine.ReleaseBall();
        }

        public virtual void AddGumballs(int count)
        {
            Console.WriteLine($"Adding {count} gumballs..");

            _gumballMachine.Count += Math.Abs(count);
        }

        protected bool HasGumballs => _gumballMachine.Count >0;
    }
}
