using DesignPatterns.Behaviours.Duck;
using DesignPatterns.Common;
using System;

namespace DesignPatterns.Adapter
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
            IDuck mallardDuck = new MallardDuck();
            IDuck bathroomDuck = new BathroomDuck();

            ITurkey wildTurkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);

            IDuck[] ducks = { mallardDuck, bathroomDuck, turkeyAdapter };

            foreach (var duck in ducks)
            {
                duck.About();
                duck.Quack();
                duck.Fly();
                duck.Swim();
            }
        }

        private void Test2()
        {
            IDuck mallardDuck = new MallardDuck();
            IDuck bathroomDuck = new BathroomDuck();
            ITurkey malldardDuckAdapter = new DuckAdapter(mallardDuck);
            ITurkey bathroomDuckAdapter = new DuckAdapter(bathroomDuck);

            ITurkey wildTurkey = new WildTurkey();

            ITurkey[] turkeys = { malldardDuckAdapter, bathroomDuckAdapter, wildTurkey };

            foreach (var turkey in turkeys)
            {
                turkey.Info();
                turkey.Gobble();
                turkey.Fly();
            }
        }
    }
}
