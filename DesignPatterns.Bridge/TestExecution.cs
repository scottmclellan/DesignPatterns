using DesignPatterns.Common;
using System;

namespace DesignPatterns.Bridge
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
            var tv = new RCA();
            var remote = new ConcreteRemoteControl(tv);

            remote.On();
            remote.SetChannel(10);
            remote.NextChannel();
            remote.PreviousChannel();
            remote.Off();
        }
    }
}
