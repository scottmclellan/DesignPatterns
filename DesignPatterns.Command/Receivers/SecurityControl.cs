using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class SecurityControl : OnOffBase
    {
        public SecurityControl(string receiverName) : base(receiverName)
        {
        }

        private string SecurityControlState
        {
            get
            {
                return IsOn ? "Armed" : "Disarmed";
            }
        }
    

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} SecurityControl is currently {SecurityControlState}");
        }
       
    }
}
