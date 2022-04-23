using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public abstract class HouseBuilderBase
    {
        private House _result = new House();

        public HouseBuilderBase(string houseName)
        {
            _result.Name = houseName;
        }

        protected void BuildDoors(int cnt) => _result.NumberOfDoors = cnt;

        protected void BuildGarage(int cnt) => _result.NumberOfGarageDoors = cnt;

        protected void BuildRoof(string material) => _result.RoofMaterial = material;

        protected void BuildWalls(string material) => _result.ExteriorMaterial = material;

        protected void BuildWindows(int cnt) => _result.NumberOfWindows = cnt;

        public House GetResult()
        {
            return _result;
        }
    }
}
