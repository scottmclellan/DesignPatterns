namespace DesignPatterns.Facade
{
    public interface IOnOff:IEquipment
    {
        void On();
        void Off();
    }
}