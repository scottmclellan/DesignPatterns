using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class RemoteControl 
    {
        private ICommand[] _onCommands;
        private ICommand[] _offCommands;
        private ICommand _undoCommand;

        private int _numberOfSlots;

        public RemoteControl(int numberOfSlots) 
        {
            _numberOfSlots = numberOfSlots;
            _onCommands = new ICommand[numberOfSlots];
            _offCommands = new ICommand[numberOfSlots];

            var noCommand = new NoCommand();

            for (int i = 0; i < _numberOfSlots; i++)
            {              
                _onCommands[i] = noCommand;
                _offCommands[i] = noCommand;
            }

            _undoCommand = noCommand;
        }

        public void SetCommand(int slot, ICommand onCommand, ICommand offCommand)
        {
            if (slot+1 > _numberOfSlots) return;


            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            if (slot +1> _onCommands.Length) return;

        

            _onCommands[slot].Execute();
            _undoCommand = _onCommands[slot];
        }


        public void OffButtonWasPushed(int slot)
        {
            if (slot+1 > _onCommands.Length) return;

           

            _offCommands[slot].Execute();
            _undoCommand = _offCommands[slot];
        }

        public void UndoButtonWasPushed()
        {
            _undoCommand.Undo();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**************** Remote Control ********************");

            for (int i = 0; i < _numberOfSlots; i++)
            {
                sb.AppendLine($"[slot {i}] {_onCommands[i].GetType().Name} \t {_offCommands[i].GetType().Name}");
            }

            sb.AppendLine($"[undo] {_undoCommand.GetType().Name}");

            return sb.ToString();
        }
    }
}
