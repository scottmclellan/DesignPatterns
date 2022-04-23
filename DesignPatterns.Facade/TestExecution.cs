using DesignPatterns.Common;
using System;

namespace DesignPatterns.Facade
{
    public class TestExecution : ITestExecute
    {
        public void Execute()
        {
            TestUtils.ClearTests();

            var homeTheatreFacade = new HomeTheatreFacade(new Amplifier("Sony amplifier"), new PopcornMaker(), new StreamPlayer(), new ProjectionScreen(), new Light("Home theatre light"), new Tuner("Samsung tuner"), new Projector("Epson Projector"));

            TestUtils.AddTest(() =>
            {            
                homeTheatreFacade.WatchMovie("Dune");
            });

            TestUtils.AddTest(() =>
            {
                homeTheatreFacade.EndMovie();
            });

            TestUtils.ExecuteTests();
        }
    }
}
