namespace DesignPatterns.Facade
{
    public class Amplifier : OnOffBase, IAmplifier
    {
        public Amplifier(string name) : base(name)
        {
        }    

        public void SetStreamPlayer(IPlayer player)
        {
            Output($"Set Stream Player to {player.Name}");
        }

        public void SetSurroundSound()
        {
            Output("Setting to Surround Sound mode");
        }

        public void SetVolume(int volume)
        {
            Output($"Setting volume to {volume}");
        }
    }
}