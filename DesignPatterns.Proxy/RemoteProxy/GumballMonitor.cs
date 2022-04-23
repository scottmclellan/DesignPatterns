using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class GumballMonitor
    {
        private GumballMachine _gumballMachine;

        public GumballMonitor(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        
        public void Report()
        {
            Console.WriteLine($"Gumball Machine: {_gumballMachine.Location}");
            Console.WriteLine($"Current inventory: {_gumballMachine.Count}");
            Console.WriteLine($"Current state: {_gumballMachine.CurrentState}");
        }
    }
}
