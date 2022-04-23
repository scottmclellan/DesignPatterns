using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatterns.Compound
{
    public class DuckSimulator
    {
        public void Simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.CreateMallardDuck();
            IQuackable redheadDuck = duckFactory.CreateRedheadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();

            Goose goose = new Goose();
            IQuackable gooseAdapter = new QuackCounter(new GooseAdapter(goose));

            Console.WriteLine("Duck Simulator");

            var ducks = new List<IQuackable> { mallardDuck, redheadDuck, duckCall, rubberDuck, gooseAdapter };

            ducks.ForEach(duck => Simulate(duck));

            Flock flockOfDucks = new Flock();
            flockOfDucks.Add(ducks.ToArray());

            Flock flockOfMallards = new Flock();
            flockOfMallards.Add(duckFactory.CreateMallardDuck(), duckFactory.CreateMallardDuck(), duckFactory.CreateMallardDuck(), duckFactory.CreateMallardDuck());

            Console.WriteLine("\nDuck Simulator: Whole Flock Simulation");
            Simulate(flockOfDucks);

            Console.WriteLine("\nDuck Simulator: Mallard Flock Simulation");
            Simulate(flockOfMallards);

            flockOfDucks.Add(flockOfMallards);

            Console.WriteLine("\nDuck Simulator: With Observer");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.RegisterObserver(quackologist);
            Simulate(flockOfDucks);

            Console.WriteLine($"Number of quacks: {QuackCounter.GetQuacks()}");

        }



        private void Simulate(IQuackable quackable)
        {
            quackable.Quack();
        }
    }
}
