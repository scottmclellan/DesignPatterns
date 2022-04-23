using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class WeatherDataUpdateInfo : IWeatherDataUpdateInfo
    {


        public double Temp { get; private set; }

        public double Humidity { get; private set; }

        public double Pressure { get; private set; }

        public WeatherDataUpdateInfo(double temp, double humidity, double pressure)
        {
            Temp = temp;
            Humidity = humidity;
            Pressure = pressure;
        }
    }
}
