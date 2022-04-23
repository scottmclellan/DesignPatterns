using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class StatisticsDisplay : ObserverBase, IDisplay, IObserver
    {
        public  void Display()
        {
            Console.WriteLine($"Temp: {GetTemp()}");
            Console.WriteLine($"Humidity: {GetHumidity()}");
            Console.WriteLine($"Pressure: {GetPressure()}");
        }

        private string GetPressure()
        {
            if (_weatherDataInfo == null) return "N/A";

            return String.Format("{0}kPa", _weatherDataInfo.Pressure);
        }

        private object GetHumidity()
        {
            if (_weatherDataInfo == null) return "N/A";

            return (_weatherDataInfo.Humidity/100.00D).ToString("P");
        }

        private string GetTemp()
        {
            if (_weatherDataInfo == null) return "N/A";

            return String.Format("{0}\u00B0C", _weatherDataInfo.Temp);
        }
     
    }
}
