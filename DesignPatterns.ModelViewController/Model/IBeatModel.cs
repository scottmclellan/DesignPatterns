using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ModelViewController
{
    public interface IBeatModel
    {
        void Initialize();
        void On();
        void Off();
        void SetBPM(int bmp);
        int GetBPM();
        void RegisterObserver(IBeatObserver o);
        void RemoveObserver(IBeatObserver o);
        void RegisterObserver(IBPMObserver o);
        void RemoveObserver(IBPMObserver o);
    }
}
