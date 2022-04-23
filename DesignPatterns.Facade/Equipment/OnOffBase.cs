using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Facade
{
    public abstract class OnOffBase : EquipmentBase, IOnOff, IEquipment
    {
      

        public OnOffBase(string name):base(name)
        {
        }

        public void On()
        {
            Output("Turning On");
            
        }

        public void Off()
        {
            Output("Turning Off");
        }       
     
    }
}
