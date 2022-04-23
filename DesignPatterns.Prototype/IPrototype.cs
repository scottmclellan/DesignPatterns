using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Prototype
{
   public interface IPrototype<T> 
    {
        T Clone();
    }
}
