using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class Director
    {
        private  IHouseBuilder _builder;

        public Director(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IHouseBuilder builder)
        {
            _builder = builder;
        }


        public void MakeHouse()
        {
            _builder.BuildDoors();
            _builder.BuildGarage();
            _builder.BuildRoof();
            _builder.BuildWalls();
            _builder.BuildWindows();           
               
        }
    }
}