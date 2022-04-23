using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class FaucetControl : OnOffBase
    {
        public FaucetControl(string receiverName) : base(receiverName)
        {
        }

        private string FaucetControlState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }
    

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Faucet Control is currently {FaucetControlState}");
        }
       
    }
}
