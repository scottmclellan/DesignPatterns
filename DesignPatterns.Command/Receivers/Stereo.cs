using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class Stereo : OnOffBase
    {
        private int _volumeLevel=5;

        private string _mode = "Radio";
     
        private string StereoState
        {
            get
            {
                return IsOn ? "On" : "Off";
            }
        }

        public Stereo(string stereoName) : base(stereoName)
        {

        }

        public void SetCd()
        {
            _mode = "CD";
        }

        public void SetDvd()
        {
            _mode = "DVD";
        }

        public void SetRadio()
        {
            _mode = "Radio";
        }

        public void SetVolume(int level)
        {
            _volumeLevel = level;
        }

        public int GetVolume()
        {
            return _volumeLevel;
        }

    

        public override void OutputState()
        {
            Console.WriteLine($"{ReceiverName} Stereo is currently {StereoState}");

            if (IsOn)
            {
                Console.WriteLine($"{ReceiverName} Stereo volume is currently {_volumeLevel}");
                Console.WriteLine($"{ReceiverName} Stereo mode is currently {_mode}");
            }
        }
       
    }
}
