using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public abstract class CeilingFanCommandBase
    {
        protected CeilingFan _ceilingFan;
        private CeilingFan.CeilingFanSpeed _lastSpeed;

        public CeilingFanCommandBase(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        protected void SetSpeed(CeilingFan.CeilingFanSpeed speed)
        {
            _lastSpeed = _ceilingFan.GetFanSpeed();
            _ceilingFan.Set(speed);
            _ceilingFan.OutputState();
        }

        public void Undo()
        {
            _ceilingFan.Set(_lastSpeed);
            _ceilingFan.OutputState();
        }
    }
}
