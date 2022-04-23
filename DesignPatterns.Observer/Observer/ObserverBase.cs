using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public abstract class ObserverBase
    {
        protected IWeatherDataUpdateInfo _weatherDataInfo;

        public void Update(IWeatherDataUpdateInfo info)
        {
            _weatherDataInfo = info;
        }

        public void ClearData()
        {
            _weatherDataInfo = null;
        }
    }
}
