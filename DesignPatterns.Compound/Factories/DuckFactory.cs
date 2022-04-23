using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Compound
{
    public class DuckFactory : AbstractDuckFactory
    {     

        public override IQuackable CreateMallardDuck() => new MallardDuck();

        public override IQuackable CreateRedheadDuck() => new RedheadDuck();

        public override IQuackable CreateDuckCall() => new DuckCall();

        public override IQuackable CreateRubberDuck() => new RubberDuck();
    }
}
