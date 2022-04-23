using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Common
{
    public static class TestUtils
    {
        public static void OutputTestHeader(int testNumber)
        {
            Console.WriteLine("");
            Console.WriteLine($"*********** TEST {testNumber} *************");
            Console.WriteLine("");
        }

        public static void OutputCustomTestHeader(string header)
        {
            Console.WriteLine("");
            Console.WriteLine($"************************");
            Console.WriteLine(header);
            Console.WriteLine($"************************");
            Console.WriteLine("");
        }

        public static void ExecuteTest(int testNumber, Action test)
        {
            OutputTestHeader(testNumber);

            test();

            Console.WriteLine("Press enter to continue:");
            Console.ReadLine();
        }

        private static List<Action> _tests = new List<Action>();

        public static void AddTest(Action test)
        {
            _tests.Add(test);
        }

        public static void ClearTests()
        {
            _tests.Clear();
        }

        public static void ExecuteTests()
        {
            for (int i = 0; i < _tests.Count; i++)
            {
                ExecuteTest(i+1, _tests[i]);
            }
        }

    }
}
