using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class ComplaintHandler : HandlerBase, IHandler
    {
        protected override string HandledMessage => "Message has been forwarded to legal department";

        public ComplaintHandler(HandlerBase nextHandler) : base("Complaint handler", nextHandler)
        {
        }

        public ComplaintHandler() : base("Complaint handler")
        { }

        protected override bool HandleCheck(Email email) => email.Message.Contains("My child is addicted to gumballs");
    }
}
