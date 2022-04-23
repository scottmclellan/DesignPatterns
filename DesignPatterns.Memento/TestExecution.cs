using DesignPatterns.Common;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Memento
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
            var history = new History();

            history.Restore();

            Editor editor = new Editor() { Text = "Initial State", CurX = 1, CurY = 1, SelectionWidth = 100 };

            history.CreateHistory(editor);

            Thread.Sleep(4000);

            editor.Text = "Second State";
            editor.CurX = 2;
            editor.CurY = 2;
            editor.SelectionWidth = 50;

            history.CreateHistory(editor);

            Thread.Sleep(4000);

            editor.Text = "Third State";
            editor.CurX = 3;
            editor.CurY = 3;
            editor.SelectionWidth = 25;

            Console.Write(editor.ToString());

            history.Restore();

            Console.WriteLine(editor.ToString());

            history.Restore();

            Console.WriteLine(editor.ToString());
        }
    }
}
