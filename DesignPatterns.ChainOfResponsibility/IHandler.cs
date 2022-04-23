using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ChainOfResponsibility
{
    public interface IHandler
    {        
        bool Handle(Email email);
    }
}
