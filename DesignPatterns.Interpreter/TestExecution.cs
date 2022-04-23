using DesignPatterns.Common;
using System;

namespace DesignPatterns.Interpreter
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
            throw new NotImplementedException();
        }
    }
}
