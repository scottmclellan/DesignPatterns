using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Appliance : OnOffBase
    {
        public Appliance(string receiverName) : base(receiverName)
        {
        }

        private string ApplianceState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }
    

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Appliance is currently {ApplianceState}");
        }
       
    }
}
