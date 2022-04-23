using DesignPatterns.Common;
using System;

namespace DesignPatterns.Flyweight
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            TestUtils.AddTest(Test1);

            TestUtils.ExecuteTests();
        }

        private string[][] _treeTypes = new string[][]{ 
            new[]{ "Maple", "Leafy", "Green" }, 
            new[]{ "Oak", "Leafy", "Green" }, 
            new[]{ "Pine", "Prickly", "Dark Green" }, 
            new[]{ "Cedar", "Prickly", "Dark Green" } ,
            new[]{ "Willow", "Leafy", "Light Green" } 
        };

        private void Test1()
        {
            Forest forest = new Forest();

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int x = random.Next(100);
                int y = random.Next(100);

                var treeDetails = _treeTypes[random.Next(_treeTypes.Length)];

                forest.PlantTree(x, y, treeDetails[0], treeDetails[1], treeDetails[2]);
            }

            forest.Draw();

        }
    }
}
