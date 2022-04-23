namespace DesignPatterns.Facade
{
    public class PopcornMaker : OnOffBase, IPopcornMaker
    {
        public PopcornMaker(string name="Orville") : base(name)
        {
        }

        public void Pop()
        {
            Output("Popping the pop corn.. yum");
        }
       
    }
}