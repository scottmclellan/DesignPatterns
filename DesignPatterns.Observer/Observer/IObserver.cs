using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Observer
{
    public interface IObserver 
    {
        void Update(IWeatherDataUpdateInfo info );
    }
}
