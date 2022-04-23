namespace DesignPatterns.Facade
{
    public interface IAmplifier : IOnOff
    {

        void SetStreamPlayer(IPlayer player);
        void SetVolume(int volume);
        void SetSurroundSound();
    }
}