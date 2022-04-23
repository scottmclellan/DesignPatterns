using Castle.DynamicProxy;
using DesignPatterns.Common;
using System;
using System.Threading;

namespace DesignPatterns.Proxy
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            TestUtils.AddTest(Test1);

            TestUtils.AddTest(Test2);

            TestUtils.AddTest(Test3);

            TestUtils.ExecuteTests();
        }

        private void Test1()
        {
            TestUtils.OutputCustomTestHeader("Remote Proxy Test");

            Console.WriteLine("Would have to learn WCF to do that.. so didn't bother");
        }

        private void Test2()
        {
            TestUtils.OutputCustomTestHeader("Virtual Proxy Test");           

            var image = new ImageToASCIIConverter();

            image.Display();
        }

        private void Test3()
        {
            TestUtils.OutputCustomTestHeader("Protection Proxy Test");

            var proxyGenerator = new ProxyGenerator();

            var person = new Person() { Name = "Scott", Gender = "M", Interests = "Photography, Curling" };

            var ownerPersonInvocationHandler = new OwnerInvocationHandler(person);

            var nonOwnerPersonInvocationHandler = new NonOwnerInvocationHandler(person);

            var ownerProxy = proxyGenerator.CreateClassProxyWithTarget<Person>(person, ownerPersonInvocationHandler);

            var nonOwnerProxy = proxyGenerator.CreateClassProxyWithTarget<Person>(person, nonOwnerPersonInvocationHandler);

            Console.WriteLine("**************************************");
            Console.WriteLine("Owned Proxy Test");
            Console.WriteLine("**************************************");

            Console.WriteLine($"Name: {ownerProxy.Name}");
            Console.WriteLine($"Gender: {ownerProxy.Gender}");
            Console.WriteLine($"Interests: {ownerProxy.Interests}");
            Console.WriteLine($"Geek Rating: {ownerProxy.GeekRating}");

            Console.WriteLine("Setting Name..");
            ownerProxy.Name = "Scott David McLellan";
            Console.WriteLine("Setting Interests..");
            ownerProxy.Interests += ", Camping";
            Console.WriteLine("Setting Geek Rating..");
            ownerProxy.GeekRating = 10;

            Console.WriteLine($"Name: {ownerProxy.Name}");
            Console.WriteLine($"Gender: {ownerProxy.Gender}");
            Console.WriteLine($"Interests: {ownerProxy.Interests}");
            Console.WriteLine($"Geek Rating: {ownerProxy.GeekRating}");


            Console.WriteLine("**************************************");
            Console.WriteLine("Non Owned Proxy Test");
            Console.WriteLine("**************************************");

            Console.WriteLine($"Name: {nonOwnerProxy.Name}");
            Console.WriteLine($"Gender: {nonOwnerProxy.Gender}");
            Console.WriteLine($"Interests: {nonOwnerProxy.Interests}");
            Console.WriteLine($"Geek Rating: {nonOwnerProxy.GeekRating}");

            Console.WriteLine("Setting Name..");
            nonOwnerProxy.Name = "Scott David McLellan";
            Console.WriteLine("Setting Interests..");
            nonOwnerProxy.Interests += ", Camping";
            Console.WriteLine("Setting Geek Rating..");
            nonOwnerProxy.GeekRating = 10;

            Console.WriteLine($"Name: {nonOwnerProxy.Name}");
            Console.WriteLine($"Gender: {nonOwnerProxy.Gender}");
            Console.WriteLine($"Interests: {nonOwnerProxy.Interests}");
            Console.WriteLine($"Geek Rating: {nonOwnerProxy.GeekRating}");
        }
    }
}
