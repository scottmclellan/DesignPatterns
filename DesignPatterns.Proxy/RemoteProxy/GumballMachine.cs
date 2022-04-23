using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class GumballMachine 
    {
        private IGumballState _soldOutState;
        private IGumballState _soldState;
        private IGumballState _noQuarterState;
        private IGumballState _hasQuarterState;
        private IGumballState _winnerState;

        private IGumballState _currentState;

        private int _count;

        private string _location;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public string Location { get => _location; set => _location = value; }
        public IGumballState CurrentState { get => _currentState; set => _currentState = value; }

        public GumballMachine(string location, int count)
        {
            _count = count;
            _location = location;

            _soldOutState = new SoldOutState(this);
            _soldState = new SoldState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _winnerState = new WinnerState(this);

            _currentState = _noQuarterState;

        }

        public void SetState(IGumballState gumballState)
        {
            _currentState = gumballState;
        }

        public IGumballState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IGumballState GetSoldState()
        {
            return _soldState;
        }

        public IGumballState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IGumballState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IGumballState GetWinnerState()
        {
            return _winnerState;
        }

        public void InsertQuarter()
        {
            _currentState.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _currentState.EjectQuarter();
        }

        public void TurnCrank()
        {
            _currentState.TurnCrank();
            _currentState.Dispense();
        }

        public void AddGumballs(int count)
        {
            _currentState.AddGumballs(count);
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out of the slot...");
            
            if (Count > 0)
                Count--;
        }
    }
}
