using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public abstract class ReceiverBase : IOutputState
    {
        private string _receiverName;
        public ReceiverBase(string receiverName)
        {
            _receiverName = receiverName;
        }

        protected string ReceiverName => _receiverName;

        public abstract void OutputState();

       
    }
}
