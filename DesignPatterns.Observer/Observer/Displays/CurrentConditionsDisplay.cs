using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class CurrentConditionsDisplay : ObserverBase, IObserver, IDisplay
    {
        public void Display()
        {
            Console.WriteLine($"Current Condition is {GetCondition()}");
        }

        private string GetCondition()
        {
            if (_weatherDataInfo == null)
                return "N/A";

            if (_weatherDataInfo.Temp < 0.0D)
                return "Freezing";

            if (_weatherDataInfo.Temp > 0.0D && _weatherDataInfo.Temp < 15.0D)
                return "Cool";

            if (_weatherDataInfo.Temp > 15.0D && _weatherDataInfo.Temp < 25.0D)
                return "Pleasant";

            if (_weatherDataInfo.Temp > 25.0D)
                return "Hot";

            return "N/A";

        }
    }
}
