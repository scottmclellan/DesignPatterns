using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("$Empty command, nothing to execute.");
        }

        public void Undo()
        {
            Console.WriteLine("$Empty command, nothing to undo.");
        }
    }
}
