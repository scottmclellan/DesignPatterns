using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class SimpleRemoteControl 
    {
        private ICommand _slot;

        public SimpleRemoteControl() { }

        public void SetCommand(ICommand command)
        {
            _slot = command;
        }

        public void ButtonWasPressed()
        {
            _slot.Execute();
        }
    }
}
