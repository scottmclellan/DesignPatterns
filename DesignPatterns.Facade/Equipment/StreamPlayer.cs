namespace DesignPatterns.Facade
{
    public class StreamPlayer : OnOffBase, IPlayer
    {
        public StreamPlayer(string name = "Stream Player") : base(name)
        {
        }

        public void PlayMovie(string movie)
        {
            Output($"Starting movie {movie}");
        }

        public void Stop()
        {
            Output("Stopping movie");
        }
    }
}