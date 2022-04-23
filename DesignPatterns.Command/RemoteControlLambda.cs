using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Command
{
    public class RemoteControlLambda
    {
        private Action[] _onCommands;
        private Action[] _offCommands;

        private int _numberOfSlots;

        public RemoteControlLambda(int numberOfSlots)
        {
            _numberOfSlots = numberOfSlots;
            _onCommands = new Action[numberOfSlots];
            _offCommands = new Action[numberOfSlots];

            var noCommand = new NoCommand();

            for (int i = 0; i < _numberOfSlots; i++)
            {
                _onCommands[i] = () => noCommand.Execute();
                _offCommands[i] = () => noCommand.Execute();
            }
        }

        public void SetCommand(int slot, Action onCommand, Action offCommand)
        {
            if (slot + 1 > _numberOfSlots) return;


            _onCommands[slot] = onCommand;
            _offCommands[slot] = offCommand;
        }

        public void OnButtonWasPushed(int slot)
        {
            if (slot + 1 > _onCommands.Length) return;



            _onCommands[slot]();
        }


        public void OffButtonWasPushed(int slot)
        {
            if (slot + 1 > _onCommands.Length) return;



            _offCommands[slot]();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("**************** Remote Control ********************");

            for (int i = 0; i < _numberOfSlots; i++)
            {
                sb.AppendLine($"[slot {i}] {_onCommands[i].GetType().Name} \t {_offCommands[i].GetType().Name}");
            }

            return sb.ToString();
        }
    }
}
