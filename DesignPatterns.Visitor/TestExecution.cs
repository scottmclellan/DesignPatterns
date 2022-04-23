using DesignPatterns.Common;
using System;

namespace DesignPatterns.Visitor
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
            var allMenus = new Menu("All Menus", "All menus combined");

            allMenus.Add(new DinerMenu());
            allMenus.Add(new PancakeHouseMenu());
            allMenus.Add(new MilestonesMenu());

            var menuComponentVisitor = new MenuComponentVisitor();

            allMenus.AcceptVisitor(menuComponentVisitor);

        }
    }
}
