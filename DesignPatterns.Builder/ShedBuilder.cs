using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class ShedBuilder : HouseBuilderBase, IHouseBuilder
    {
        public ShedBuilder() : base("Shed")
        { 
        }

        public void BuildWalls()
        {
            base.BuildWalls("Board and Batton");
        }

        public void BuildDoors()
        {
            base.BuildDoors(1);
        }

        public void BuildWindows()
        {
            base.BuildWindows(2);
        }

        public void BuildRoof()
        {
            base.BuildRoof("Asphalt");
        }

        public void BuildGarage()
        {
            base.BuildGarage(0);
        }
    }
}
