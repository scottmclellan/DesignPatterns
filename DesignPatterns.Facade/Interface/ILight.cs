namespace DesignPatterns.Facade
{
    public interface ILight : IOnOff
    {
        void Dim(int level);
    }
}