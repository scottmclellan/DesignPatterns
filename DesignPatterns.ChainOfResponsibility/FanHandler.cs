using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class FanHandler : HandlerBase, IHandler
    {
        protected override string HandledMessage => "Message has been forwarded to CEO";

        public FanHandler(HandlerBase nextHandler) : base("Fan mail handler", nextHandler)
        {
        }

        public FanHandler() : base("Fan mail handler")
        { }

        protected override bool HandleCheck(Email email) => email.Message.Contains("I love your gumball machine");
        }
}
