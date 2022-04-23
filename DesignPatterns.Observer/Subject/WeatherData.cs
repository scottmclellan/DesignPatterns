using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public class WeatherData : SubjectBase, ISubject
    {

        private Random _random = new Random();
        private IWeatherDataUpdateInfo _weatherDataInfo;

        public override void NotifyObservers()
        {

            if (_weatherDataInfo == null) GenerateWeather();

            foreach(var observer in _observers)
            {
                observer.Update(_weatherDataInfo);                
            }
        }    
        
        public void GenerateWeather()
        {
            _weatherDataInfo = new WeatherDataUpdateInfo(GetRandomTemp(), GetRandomHumidity(), GetRandomPressure());
        }


        private double GetRandomTemp()
        {
            return _random.NextDouble() * 40.00;
        }

        private double GetRandomHumidity()
        {
            return _random.NextDouble() * 100.00;
        }

        private double GetRandomPressure()
        {
            return _random.NextDouble() * 140.00;
        }
    }
}
