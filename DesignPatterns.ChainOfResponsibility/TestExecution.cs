using DesignPatterns.Common;
using System;

namespace DesignPatterns.ChainOfResponsibility
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
            var handler = CreateEmailHandler();

            TestUtils.OutputCustomTestHeader("Spam email test");           

            Email email = new Email() { Message = "I am a Nigerian Prince" };

            handler.Handle(email);

            TestUtils.OutputCustomTestHeader("Complaint email test");

            email = new Email() { Message = "My child is addicted to gumballs" };

            handler.Handle(email);

            TestUtils.OutputCustomTestHeader("Fan email test");

            email = new Email() { Message = "I love your gumball machine" };

            handler.Handle(email);

            TestUtils.OutputCustomTestHeader("New Location email test");

            email = new Email() { Message = "Need a gumball machine in" };

            handler.Handle(email);


            TestUtils.OutputCustomTestHeader("Unhandled email test");

            email = new Email() { Message = "Just some random email" };

            handler.Handle(email);

        }

        private HandlerBase CreateEmailHandler()
        {
            HandlerBase handler ;

            handler = new FanHandler();
            handler = new ComplaintHandler(handler);
            handler = new SpamHandler(handler);
            handler = new NewLocHander(handler);

            return handler;
        }
    }
}
