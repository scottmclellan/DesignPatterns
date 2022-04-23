using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class OnCommand<T> : ICommand where T:OnOffBase, IOutputState
    {
        private T _onOffItem;

        public OnCommand(T item) 
        {
            _onOffItem = item;
        }

        public void Execute()
        {
            _onOffItem.On();
            _onOffItem.OutputState();
        }

        public void Undo()
        {
            _onOffItem.Off();
            _onOffItem.OutputState();
        }
    }
}
