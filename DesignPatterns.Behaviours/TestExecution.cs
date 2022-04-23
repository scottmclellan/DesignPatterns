using DesignPatterns.Behaviours.Duck;
using DesignPatterns.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behaviours
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            TestUtils.AddTest(() =>
            {
                var ducks = new List<IDuck>()
            {
                new BathroomDuck(),
                new DecoyDuck(),
                new MallardDuck()
            };

                ducks.ForEach((d) =>
                {
                    d.About();
                    d.Fly();
                    d.Swim();
                    d.Quack();
                });
            });

            TestUtils.ExecuteTests();
        }
    }
}
