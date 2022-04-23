using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class SpamHandler : HandlerBase, IHandler
    {
        protected override string HandledMessage => "Message has been deleted";

        public SpamHandler(HandlerBase nextHandler) : base("Spam mail handler", nextHandler)
        {
        }

        public SpamHandler() : base("Spam mail handler")
        { }

        protected override bool HandleCheck(Email email) => email.Message.Contains("I am a Nigerian Prince");
     
    }
}
