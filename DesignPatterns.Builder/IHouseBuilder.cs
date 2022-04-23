namespace DesignPatterns.Builder
{
    public interface IHouseBuilder
    {
        void BuildDoors();
        void BuildGarage();
        void BuildRoof();
        void BuildWalls();
        void BuildWindows();
        House GetResult();
    }
}