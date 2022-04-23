using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class CeilingFanLowCommand : CeilingFanCommandBase, ICommand
    {    

        public CeilingFanLowCommand(CeilingFan ceilingFan):base(ceilingFan)
        {           
        }

        public void Execute()
        {
            SetSpeed(CeilingFan.CeilingFanSpeed.Low);
        }
       
    }
}
