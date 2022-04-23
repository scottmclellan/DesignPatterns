using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behaviours.Quack
{
    public class Quacker : IQuackBehavior
    {
       public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
