using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Light : OnOffBase
    {
        public Light(string receiverName) : base(receiverName)
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
            Console.WriteLine($"{ReceiverName} Light is currently {LightState}");
        }

    }
}
