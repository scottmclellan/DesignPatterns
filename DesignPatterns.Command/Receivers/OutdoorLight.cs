using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class OutdoorLight : OnOffBase
    {
        public OutdoorLight(string receiverName) : base(receiverName)
        {
        }

        private string LightState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }
    

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Outdoor Light is currently {LightState}");
        }
       
    }
}
