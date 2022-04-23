using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class GarageDoorCloseCommand : ICommand 
    {
        private GarageDoor _garageDoor;

        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }

        public void Execute()
        {
            _garageDoor.Close();
            _garageDoor.OutputState();
        }

        public void Undo()
        {
            _garageDoor.Open();
            _garageDoor.OutputState();
        }
    }
}
