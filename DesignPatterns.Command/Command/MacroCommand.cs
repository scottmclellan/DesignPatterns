using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class MacroCommand : ICommand
    {
        private ICommand[] _commands;
        public MacroCommand(params ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var command in _commands)
            {
                command.Execute();
            }        
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}
