using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class GarageDoorOpenCommand :  ICommand
    {
        private GarageDoor _garageDoor;

        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Open();
            _garageDoor.OutputState();
        }

        public void Undo()
        {
            _garageDoor.Close();
            _garageDoor.OutputState();
        }
    }
}
