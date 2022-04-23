using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class CeilingFanMediumCommand : CeilingFanCommandBase, ICommand
    {    

        public CeilingFanMediumCommand(CeilingFan ceilingFan):base(ceilingFan)
        {           
        }

        public void Execute()
        {
            SetSpeed(CeilingFan.CeilingFanSpeed.Medium);
        }
       
    }
}
