using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class CeilingFanOffCommand : CeilingFanCommandBase, ICommand
    {    

        public CeilingFanOffCommand(CeilingFan ceilingFan):base(ceilingFan)
        {           
        }

        public void Execute()
        {
            SetSpeed(CeilingFan.CeilingFanSpeed.Off);
        }
       
    }
}
