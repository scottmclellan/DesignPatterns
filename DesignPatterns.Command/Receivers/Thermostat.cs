using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Thermostat : ReceiverBase
    {
        private decimal _temperatureF;
        private decimal _temperatureC;

        public Thermostat(string receiverName) : base(receiverName)
        {
        }

        public void SetTemperatureF(decimal value)
        {
            _temperatureF = value;
            _temperatureC = (value - 32.0M) * 0.5556M;
        }

        public void SetTemperatureC(decimal value)
        {
            _temperatureC = value;
            _temperatureC = (value * 1.8M) + 32.0M;
        }

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Thermostate is set to {_temperatureC}°C or {_temperatureF}°F");
        }
    }
}
