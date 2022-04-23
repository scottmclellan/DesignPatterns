using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public abstract class EquipmentBase : IEquipment
    {

        private string _name;

        public EquipmentBase(string name)
        {
            _name = name;
        }


        public string Name => _name;

        protected void Output(string message)
        {
            Console.WriteLine($"{_name} {message}");
        }
    }
}
