using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class ForecastDisplay : ObserverBase, IObserver, IDisplay
    {
       
        public void Display()
        {
            Console.WriteLine($"Today's forecast is {GetForecast()}");
        }
     

        private string GetForecast()
            {

            if (_weatherDataInfo == null) return "No data to forecast";

            return _weatherDataInfo.Pressure > 100.0D ? "Sunny" : "Cloudy";

        }
    }
}
