using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class OffCommand<T> : ICommand where T : OnOffBase, IOutputState
    {
        private T _onOffItem;

        public OffCommand(T item)
        {
            _onOffItem = item;
        }

        public void Execute()
        {
            _onOffItem.Off();
            _onOffItem.OutputState();
        }

        public void Undo()
        {
            _onOffItem.On();
            _onOffItem.OutputState();
        }
    }
}
