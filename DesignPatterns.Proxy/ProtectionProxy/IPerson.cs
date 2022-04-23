using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public interface IPerson
    {
        string Name { get; set; }
        string Gender { get; set; }
        string Interests { get; set; }

        int GeekRating { get; set; }

    }
}
