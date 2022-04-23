namespace DesignPatterns.Facade
{
    public interface IPlayer:IOnOff
    {
        void PlayMovie(string movie);
        void Stop();
    }
}