using DesignPatterns.Common;
using System;

namespace DesignPatterns.Iterator
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            TestUtils.AddTest(Test1);

            TestUtils.AddTest(Test2);

            TestUtils.ExecuteTests();
        }

      
        private void Test1()
        {
            var dinerMenu = new DinerMenu();
            var pancakeHouseMenu = new PancakeHouseMenu();

            var waitress = new Waitress(dinerMenu, pancakeHouseMenu);

            waitress.PrintMenu();
        }

        private void Test2()
        {
            var dinerMenu = new DinerMenu();
            var pancakeHouseMenu = new PancakeHouseMenu();
            var milestonesMenu = new MilestonesMenu();

            var waitress = new Waitress(dinerMenu, pancakeHouseMenu, milestonesMenu);

            waitress.PrintMenu();
            waitress.PrintBreakfastMenu();
            waitress.PrintLunchMenu();
            waitress.PrintDinnerMenu();


        }

    }
}
