using DesignPatterns.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace DesignPatterns.ModelViewController
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
            TestUtils.OutputCustomTestHeader("Opening Beat Player");

                       

            Application app = new Application();
         
            var model = new BeatModel();
            var controller = new BeatController(model);
            app.Run(controller.View);
        }
    }
}
