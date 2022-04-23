using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class BungalowBuilder : HouseBuilderBase, IHouseBuilder
    {
        public BungalowBuilder() : base("Bungalow")
        {
        }

        public void BuildWalls()
        {
            base.BuildWalls("Brick");
        }

        public void BuildDoors()
        {
            base.BuildDoors(3);
        }

        public void BuildWindows()
        {
            base.BuildWindows(7);
        }

        public void BuildRoof()
        {
            base.BuildRoof("Asphalt");
        }

        public void BuildGarage()
        {
            base.BuildGarage(2);
        }
    }
}
