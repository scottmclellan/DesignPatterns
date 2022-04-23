using DesignPatterns.Behaviours.Fly;
using DesignPatterns.Behaviours.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behaviours.Duck
{
   public class DecoyDuck : DuckBase
    {
        public DecoyDuck():base(new MuteQuack(), new FlyNoWay())
        {            
        }

        public override void About()
        {
            Console.WriteLine("I'm a decoy!");
        }
    }
}
