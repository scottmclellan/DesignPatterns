using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class StereoOnWithCDCommand : ICommand
    {
        private Stereo _stereo;
        private int _lastVolumeLevel;

        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _lastVolumeLevel = _stereo.GetVolume();
            _stereo.On();
            _stereo.SetCd();
            _stereo.SetVolume(11);
            _stereo.OutputState();
        }

        public void Undo()
        {
            _stereo.Off();
            _stereo.SetRadio();
            _stereo.SetVolume(_lastVolumeLevel);
            _stereo.OutputState();
        }
    }
}
