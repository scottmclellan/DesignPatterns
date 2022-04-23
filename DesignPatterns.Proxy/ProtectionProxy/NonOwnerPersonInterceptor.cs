using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class NonOwnerInvocationHandler : PersonInvocationHandlerBase, IInterceptor
    {
        public NonOwnerInvocationHandler(IPerson person) : base(person)
        {
        }

        public void Intercept(IInvocation invocation)
        {

            try
            {
                if (invocation.Method.Name.StartsWith("get"))
                    invocation.Proceed();
                else if (invocation.Method.Name == "set_GeekRating")
                    invocation.Proceed();
                else if (invocation.Method.Name.StartsWith("set_"))
                    Console.WriteLine("**NO ACCESS**");
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}
