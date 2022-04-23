using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public class ConcreteRemoteControl : RemoteControl
    {
        private int _currentChannel = 1;

        public ConcreteRemoteControl(TV tv) : base(tv)
        {
        }

        public override void Off()
        {
            Implementor.Off();
        }

        public override void On()
        {
            Implementor.On();
        }

        public override void SetChannel(int channel)
        {
            _currentChannel = channel;
            Implementor.TuneChannel(channel);
        }

        public void NextChannel()
        {
            _currentChannel++;
            Implementor.TuneChannel(_currentChannel);
        }

        public void PreviousChannel()
        {
            _currentChannel--;
            Implementor.TuneChannel(_currentChannel);
        }
    }
}
