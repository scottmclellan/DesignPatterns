using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using DesignPatterns.Behaviours;
using DesignPatterns.Common;
using DesignPatterns.Observer;
using Unity;

namespace DesignPatterns.TestHarness
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ITestExecute test;

            //test = new DesignPatterns.Behaviours.TestExecution();

            //test = new DesignPatterns.Observer.TestExecution();

            //test = new DesignPatterns.Decorators.TestExecution();   

            //test = new DesignPatterns.Factory.TestExecution();

            //test = new DesignPatterns.Command.TestExecution();

            //test = new DesignPatterns.Adapter.TestExecution();

            //test = new DesignPatterns.Facade.TestExecution();

            //test = new DesignPatterns.Template.TestExecution();

            //test = new DesignPatterns.Iterator.TestExecution();

            //test = new DesignPatterns.Composite.TestExecution();

            //test = new DesignPatterns.State.TestExecution();

            //test = new DesignPatterns.Proxy.TestExecution();

            //test = new DesignPatterns.Compound.TestExecution();

            //test = new DesignPatterns.ModelViewController.TestExecution();

            //test = new DesignPatterns.Bridge.TestExecution();

            //test = new DesignPatterns.Builder.TestExecution();

            //test = new DesignPatterns.ChainOfResponsibility.TestExecution();

            //test = new DesignPatterns.Flyweight.TestExecution();

            //test = new DesignPatterns.Interpreter.TestExecution();

            //test = new DesignPatterns.Mediator.TestExecution();

            //test = new DesignPatterns.Memento.TestExecution();

            //test = new DesignPatterns.Prototype.TestExecution();

            test = new DesignPatterns.Visitor.TestExecution();

            test.Execute();

        }
    }
 
}


