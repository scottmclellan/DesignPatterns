using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public interface IConsoleImage
    {
        bool Loaded { get; }
        void Display();
    }
}
