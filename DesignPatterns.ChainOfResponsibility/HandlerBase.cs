using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class HandlerBase
    {
        private string _handlerName;

        private HandlerBase _nextHandler;

        public HandlerBase(string handlerName) : this(handlerName, null)
        { }
        public HandlerBase(string handlerName, HandlerBase nextHandler)
        {
            _handlerName = handlerName;
            _nextHandler = nextHandler;
        }

        protected void Next(Email email)
        {

        }

        public bool Handle(Email email)
        {
            if (HandleCheck(email))
            {
                Console.WriteLine("*********************");
                Console.WriteLine($"Email was handled by {_handlerName}");
                Console.WriteLine(HandledMessage);
                Console.WriteLine("*********************");
                return true;
            }
            else if (_nextHandler == null)
            {
                Console.WriteLine("Email was not handled");
                return false;
            }
            else
                return _nextHandler.Handle(email);
        }

        protected abstract bool HandleCheck(Email email);
        protected abstract string HandledMessage { get; }
    }
}
