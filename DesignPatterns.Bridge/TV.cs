using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public abstract class TV
    {
        private string _name;

        public TV(string name)
        {
            _name = name;
        }

        public virtual void On()
        {
            Console.WriteLine($"{_name} TV - turned on");
        }
        public virtual void Off()
        {
            Console.WriteLine($"{_name} TV - turned off");
        }

        public virtual void TuneChannel(int channel)
        {
            Console.WriteLine($"{_name} TV - Setting channel: {channel}");
        }

    }
}
