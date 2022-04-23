using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class CeilingFan : ReceiverBase
    {
      

        public enum CeilingFanSpeed
        {
            High,
            Medium,
            Low,
            Off
        }

        private CeilingFanSpeed _fanSpeed = CeilingFanSpeed.Off; //default to low

        public CeilingFan(string receiverName) : base(receiverName)
        {
        }

        public void SetHigh()
        {
            _fanSpeed = CeilingFanSpeed.High;
        }

        public void SetMedium()
        {
            _fanSpeed = CeilingFanSpeed.Medium;
        }

        public void SetLow()
        {
            _fanSpeed = CeilingFanSpeed.Low;
        }

        public void TurnOff()
        {
            _fanSpeed = CeilingFanSpeed.Off;
        }

        public void Set(CeilingFanSpeed speed)
        {
            _fanSpeed = speed;
        }

        public CeilingFanSpeed GetFanSpeed()
        {
            return _fanSpeed;
        }      
    

        public override void OutputState()
        {
            if(_fanSpeed != CeilingFanSpeed.Off)
            Console.WriteLine($"{ReceiverName} Celing Fan is On with fan speed set to {_fanSpeed}");
            else
                Console.WriteLine($"{ReceiverName} Celing Fan is Off");
        }
       
    }
}
