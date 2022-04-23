using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class GarageDoor : ReceiverBase
    {
        private bool _isOpen;
        private bool _isLightOn;

        public GarageDoor(string garageDoorName):base(garageDoorName)
        {

        }
        private string GarageDoorState
        {
            get
            {
                return _isOpen ? "Open" : "Closed";
            }
        }
        private string GarageLightState
        {
            get
            {
                return _isLightOn ? "On" : "Off";
            }
        }

        public void Open()
        {
            _isOpen = true;

            OutputState();
        }
        public void Close()
        {
            _isOpen = false;
            OutputState();
        }

        public void Stop()
        {

        }

        public void LightOn()
        { 
            _isLightOn = true;
            OutputState();
        }

        public void LightOff()
        {
            _isLightOn = false;
            OutputState();
        }      

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Garage door is currently {GarageDoorState}");
            Console.WriteLine($"{ReceiverName} Garage light is currently {GarageLightState}");
        }
    }
}
