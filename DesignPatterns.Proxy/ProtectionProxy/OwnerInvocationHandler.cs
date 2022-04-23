using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class OwnerInvocationHandler : PersonInvocationHandlerBase, IInterceptor
    {
        public OwnerInvocationHandler(IPerson person) : base(person)
        {
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                if (invocation.Method.Name.StartsWith("get"))
                    invocation.Proceed();
                else if (invocation.Method.Name == "set_GeekRating")
                    Console.WriteLine("**NO ACCESS**");
                else if (invocation.Method.Name.StartsWith("set_"))
                    invocation.Proceed();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }

        }
    }
}
