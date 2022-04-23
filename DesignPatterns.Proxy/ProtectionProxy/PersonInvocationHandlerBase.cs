using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public  abstract class PersonInvocationHandlerBase
    {
        protected IPerson Person { get; private set; }

        public PersonInvocationHandlerBase(IPerson person)
        {
          Person = person;
        }
    }
}
