using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public abstract class OnOffBase : ReceiverBase
    {
        private bool _isOn;
        protected bool IsOn => _isOn;

        public OnOffBase(string receiverName) : base(receiverName)
        {

        }

        public void On()
        {
            _isOn = true;
          
        }

        public void Off()
        {
            _isOn = false;
        }

      
    }
}
