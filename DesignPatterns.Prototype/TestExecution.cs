using DesignPatterns.Common;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Prototype
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
            List<Shape> listOfShapes = new List<Shape>();
            List<Shape> listOfClonedShapes = new List<Shape>();

            Circle circle = new Circle()
            {
                Diameter = 100,
                X = 10,
                Y = 20
            };

            listOfShapes.Add(circle);

            Rectangle rectangle= new Rectangle()
            {
                Width = 100,
                Height = 50,
                X = 10,
                Y = 20
            };

            listOfShapes.Add(rectangle);

            Console.WriteLine("\nOriginal Shapes");
            foreach(var shape in listOfShapes)
            {
                Console.Write(shape.ToString());

                listOfClonedShapes.Add(shape.Clone());
            }

            Console.WriteLine("\n\n\nCloned Shapes");
            foreach (var shape in listOfClonedShapes)
            {
                Console.Write(shape.ToString());
            }
        }
    }
}
