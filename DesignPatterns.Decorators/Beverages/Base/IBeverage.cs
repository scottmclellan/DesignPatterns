using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Decorators
{
    public interface IBeverage
    {
        string Description { get; }
        decimal UnitCost { get; }
        decimal TotalCost { get; }
        SizeEnum Size { get; }
    }
}
