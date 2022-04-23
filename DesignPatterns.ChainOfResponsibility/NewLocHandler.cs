using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public class NewLocHander : HandlerBase, IHandler
    {
        protected override string HandledMessage => "Message has been forwarded to business development";

        public NewLocHander(HandlerBase nextHandler) : base("New Location Handler", nextHandler)
        {
        }

        public NewLocHander() : base("New Location Handler")
        { }

        protected override bool HandleCheck(Email email) => email.Message.Contains("Need a gumball machine in");
    }
}
