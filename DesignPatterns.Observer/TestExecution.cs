using DesignPatterns.Common;
using System;

namespace DesignPatterns.Observer
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            var weatherData = new WeatherData();

            var currentConditionDisplay = new CurrentConditionsDisplay();
            var statisticsDisplay = new StatisticsDisplay();
            var forecastDisplay = new ForecastDisplay();

            weatherData.RegisterObserver(currentConditionDisplay);
            weatherData.RegisterObserver(statisticsDisplay);
            weatherData.RegisterObserver(forecastDisplay);

            weatherData.NotifyObservers();

            TestUtils.ClearTests();

            TestUtils.AddTest(() =>
            {
                currentConditionDisplay.Display();
                statisticsDisplay.Display();
                forecastDisplay.Display();

                currentConditionDisplay.ClearData();
                statisticsDisplay.ClearData();
                forecastDisplay.ClearData();

                weatherData.UnregisterObserver(currentConditionDisplay);

                weatherData.NotifyObservers();
            });

            TestUtils.AddTest(() =>
            {
                currentConditionDisplay.Display();
                statisticsDisplay.Display();
                forecastDisplay.Display();


                weatherData.RegisterObserver(currentConditionDisplay);

                weatherData.GenerateWeather();
                weatherData.NotifyObservers();
            });

            TestUtils.AddTest(() =>
            {
                currentConditionDisplay.Display();
                statisticsDisplay.Display();
                forecastDisplay.Display();
            });

            TestUtils.ExecuteTests();

        }
    }
}
