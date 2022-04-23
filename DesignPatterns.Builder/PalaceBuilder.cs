using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class PalaceBuilder : HouseBuilderBase, IHouseBuilder
    {
        public PalaceBuilder() : base("Palace")
        {
        }

        public void BuildWalls()
        {
            base.BuildWalls("Gold");
        }

        public void BuildDoors()
        {
            base.BuildDoors(10);
        }

        public void BuildWindows()
        {
            base.BuildWindows(20);
        }

        public void BuildRoof()
        {
            base.BuildRoof("Diamond");
        }

        public void BuildGarage()
        {
            base.BuildGarage(15);
        }      
    }
}
