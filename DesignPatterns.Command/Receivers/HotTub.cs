using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class HotTub : OnOffBase
    {
        public HotTub(string receiverName) : base(receiverName)
        {
        }

        public void Circulate()
        {

        }

        public void JetsOn()
        {

        }

        public void JetsOff()
        {

        }

        public void SetTemperature()
        {

        }

        private string HotTubState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }


        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Hot tub is currently {HotTubState}");
        }
    }
    
}
