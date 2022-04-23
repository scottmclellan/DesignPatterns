using DesignPatterns.Common;
using System;

namespace DesignPatterns.Compound
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
            DuckSimulator duckSimulator = new DuckSimulator();

            var duckFactory = new CountingDuckFactory();

            duckSimulator.Simulate(duckFactory);
        }
    }
}
