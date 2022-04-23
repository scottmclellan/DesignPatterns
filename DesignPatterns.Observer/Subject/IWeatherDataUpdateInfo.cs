using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface IWeatherDataUpdateInfo
    {
        double Temp { get; }
        double Humidity { get; }
        double Pressure { get; }
    }
}
