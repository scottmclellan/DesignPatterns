using DesignPatterns.Common;
using System;

namespace DesignPatterns.Decorators
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            TestUtils.AddTest(() =>
            {
                IBeverage beverage1;

                beverage1 = new MediumRoast(SizeEnum.Small);
                beverage1 = new Mocha(beverage1);
                beverage1 = new Mocha(beverage1);
                beverage1 = new Whip(beverage1);
                beverage1 = new Sugar(beverage1);

                Console.WriteLine("********** Order 1 **********");
                Console.WriteLine($"Description: {beverage1.Description}");
                Console.WriteLine($"Cost: {beverage1.TotalCost}");

            });


            TestUtils.AddTest(() =>
            {

                IBeverage beverage2;

                beverage2 = new MediumRoast(SizeEnum.Medium);
                beverage2 = new Mocha(beverage2);
                beverage2 = new Mocha(beverage2);
                beverage2 = new Whip(beverage2);
                beverage2 = new Sugar(beverage2);

                Console.WriteLine("********** Order 2 **********");
                Console.WriteLine($"Description: {beverage2.Description}");
                Console.WriteLine($"Cost: {beverage2.TotalCost}");

            });

            TestUtils.AddTest(() =>
            {

                IBeverage beverage3;

                beverage3 = new MediumRoast(SizeEnum.Large);
                beverage3 = new Mocha(beverage3);
                beverage3 = new Mocha(beverage3);
                beverage3 = new Whip(beverage3);
                beverage3 = new Sugar(beverage3);

                Console.WriteLine("********** Order 3 **********");
                Console.WriteLine($"Description: {beverage3.Description}");
                Console.WriteLine($"Cost: {beverage3.TotalCost}");
            });


            TestUtils.AddTest(() =>
            {
                IBeverage beverage4;

                beverage4 = new MediumRoast(SizeEnum.ExtraLarge);
                beverage4 = new Mocha(beverage4);
                beverage4 = new Mocha(beverage4);
                beverage4 = new Whip(beverage4);
                beverage4 = new Sugar(beverage4);

                Console.WriteLine("********** Order 4 **********");
                Console.WriteLine($"Description: {beverage4.Description}");
                Console.WriteLine($"Cost: {beverage4.TotalCost}");
            });

            TestUtils.ExecuteTests();

        }
    }
}
