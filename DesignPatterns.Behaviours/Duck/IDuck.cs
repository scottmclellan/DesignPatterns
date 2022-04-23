using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behaviours.Duck
{
    public interface IDuck
    {
        void About();
        void Fly();
        void Quack();
        void Swim();
    }
}
