using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Visitor
{
    public interface IMenuComponentVisitor
    {
        void Visit(Menu menu);
        void Visit(MenuItem menu);
    }
}
