using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Sprinkler : OnOffBase
    {
     
        public Sprinkler(string sprinklerName): base(sprinklerName)
        {

        }

        private string SprinklerState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }
    

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Sprinkler is currently {SprinklerState}");
        }
       
    }
}
