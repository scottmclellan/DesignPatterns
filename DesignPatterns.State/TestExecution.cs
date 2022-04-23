using DesignPatterns.Common;
using System;

namespace DesignPatterns.State
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            TestUtils.AddTest(Test1);

            TestUtils.ExecuteTests();
        }

        private void Test1()
        {
            var gumballMachine = new GumballMachine(2);

            gumballMachine.InsertQuarter();
            gumballMachine.EjectQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            gumballMachine.AddGumballs(2);
            gumballMachine.TurnCrank();
            gumballMachine.EjectQuarter();
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

        }
    }
}
