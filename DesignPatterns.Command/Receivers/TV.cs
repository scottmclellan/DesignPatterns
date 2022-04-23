using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class TV  : OnOffBase
    {
        public TV(string receiverName) : base(receiverName)
        {
        }

        private string TVState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }
    
        public void SetInputChannel()
        {

        }

        public void SetVolume()
        {

        }

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} TV is currently {TVState}");
        }
       
    }
}
