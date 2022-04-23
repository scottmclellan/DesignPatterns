using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class GardenLight : OnOffBase
    {
        public GardenLight(string receiverName) : base(receiverName)
        {
        }

        private string GardenLightState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }
    
        public void SetDuskTime()
        { }
    
        public void SetDawnTime()
        { }

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Garden Light is currently {GardenLightState}");
        }
       
    }
}
