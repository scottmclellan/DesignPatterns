namespace DesignPatterns.Facade
{
    public class Tuner : OnOffBase, ITuner
    {
        public Tuner(string name) : base(name)
        {
        }
    }
}