using DesignPatterns.Common;
using System;

namespace DesignPatterns.Template
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            TestUtils.AddTest(Test1);

            TestUtils.AddTest(Test2);

            TestUtils.AddTest(Test3);

            TestUtils.AddTest(Test4);

            TestUtils.ExecuteTests();
        }

        public void Test1()
        {
            //example of sub classes (Coffee/Tea) providing their own implementation for parts of the PrepareRecipe algortithm in CaffeineBeverageBase

            Coffee coffee = new Coffee();

            coffee.PrepareRecipe();


            Tea tea = new Tea();

            tea.PrepareRecipe();
        }


        public void Test2()
        {
            CoffeeNoCondiments coffee = new CoffeeNoCondiments();

            coffee.PrepareRecipe();


            TeaNoCondiments tea = new TeaNoCondiments();

            tea.PrepareRecipe();
        }

        public void Test3()
        {
            //example of sub classes (CoffeeWithHook/TeaWithHook) providing their own implementation for a Hook method that is used in the base classes (CaffeineBeverageWithHookBase) PrepareRecipe method

            CoffeeWithHook coffee = new CoffeeWithHook();

            coffee.PrepareRecipe();

            TeaWithHook tea = new TeaWithHook();

            tea.PrepareRecipe();
        }

        public void Test4()
        {
            //example of Template pattern where the static Array.Sort relies on the Duck class to implement the CompareTo method that it uses to do the sorting

            Duck[] ducks =
            {
                new Duck(9, "Lewis"),
                new Duck(1, "Miles"),
                new Duck(3, "Trish"),
                 new Duck(2, "Peeko"),
                new Duck(8, "Sammy")
            };

            Console.WriteLine("Before sorting:");

            DisplayDucks(ducks);

            Array.Sort(ducks);

            Console.WriteLine("After sorting:");

            DisplayDucks(ducks);
        }

        private void DisplayDucks(Duck[] ducks)
        {
            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i].ToString());
            }
        }
    }
}
