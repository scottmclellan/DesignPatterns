using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class CastleBuilder : HouseBuilderBase, IHouseBuilder
    {
        public CastleBuilder() : base("Castle")
        {
        }

        public void BuildWalls()
        {
            base.BuildWalls("Stone");
        }

        public void BuildDoors()
        {
            base.BuildDoors(5);
        }

        public void BuildWindows()
        {
            base.BuildWindows(100);
        }

        public void BuildRoof()
        {
            base.BuildRoof("Slate");
        }

        public void BuildGarage()
        {
            base.BuildGarage(0);
        }
    }
}
