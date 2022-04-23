using DesignPatterns.Behaviours.Fly;
using DesignPatterns.Behaviours.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behaviours.Duck
{
   public class MallardDuck : DuckBase
    {
        public MallardDuck():base(new Quacker(), new FlyWithWings())
        {            
        }

        public override void About()
        {
            Console.WriteLine("I'm a mallard!");
        }
    }
}
