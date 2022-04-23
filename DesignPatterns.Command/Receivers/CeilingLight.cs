using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class CeilingLight : OnOffBase
    {
        public CeilingLight(string receiverName) : base(receiverName)
        {
        }

        private string CeilingLightState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }
    
        public void Dim()
        { }

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Ceiling Light is currently {CeilingLightState}");
        }
       
    }
}
