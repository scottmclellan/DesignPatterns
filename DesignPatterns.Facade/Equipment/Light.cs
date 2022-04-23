namespace DesignPatterns.Facade
{
    public class Light : OnOffBase, ILight
    {
        public Light(string name) : base(name)
        {
        }

        public void Dim(int level)
        {
            Output($"Setting light level to {level}");
        }
    }
}