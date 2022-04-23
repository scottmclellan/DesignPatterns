using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class CeilingFanHighCommand : CeilingFanCommandBase, ICommand
    {    

        public CeilingFanHighCommand(CeilingFan ceilingFan):base(ceilingFan)
        {           
        }

        public void Execute()
        {
            SetSpeed(CeilingFan.CeilingFanSpeed.High);
        }
       
    }
}
