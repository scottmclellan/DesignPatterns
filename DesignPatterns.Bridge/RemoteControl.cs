using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Bridge
{
    public abstract class RemoteControl
    {
        protected TV Implementor { get; private set; }

        public RemoteControl(TV tv)
        {
            Implementor = tv;
        }

        public abstract void On();
        public abstract void Off();
        public abstract void SetChannel(int channel);
    }
}
