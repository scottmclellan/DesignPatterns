using DesignPatterns.Common;
using System;

namespace DesignPatterns.Mediator
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
            Console.WriteLine("Nothing too special here, basically the example is a windows form. The form serves as the mediator between all of the individual controls on the screen");
        }
    }
}
