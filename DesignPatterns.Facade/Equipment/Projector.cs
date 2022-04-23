namespace DesignPatterns.Facade
{
    public class Projector : OnOffBase, IProjector
    {
        public Projector(string name = "Projector") : base(name)
        {
        }

        public void WideScreenMode()
        {
            Output("Set to Widescreen Mode");
        }
    }
}