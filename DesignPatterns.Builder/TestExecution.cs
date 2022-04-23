using DesignPatterns.Common;
using System;

namespace DesignPatterns.Builder
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
            Director director = null;
            House house = null;

            var builders = new IHouseBuilder[]{
                new ShedBuilder(),
                new BungalowBuilder(),
                new CastleBuilder(),
                new PalaceBuilder() };

            for (int i = 0; i < builders.Length; i++)
            {
                if (i == 0)
                    director = new Director(builders[i]);
                else
                    director.ChangeBuilder(builders[i]);

                director.MakeHouse();

                house = builders[i].GetResult();

                Console.Write(house);                    

            }

        }
    }
}
