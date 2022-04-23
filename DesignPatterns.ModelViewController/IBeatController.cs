using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ModelViewController
{
    public interface IBeatController
    {
        void Start();
        void Stop();
        void IncreaseBPM();
        void DecreaseBPM();
        void SetBPM(int bpm);
    }
}
