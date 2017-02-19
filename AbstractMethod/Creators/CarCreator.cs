using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractMethod.Interfaces;
using AbstractMethod.Vehicles;

namespace AbstractMethod.Creators
{
    class CarCreator : ICreator
    {
        public IVehicle FactoryMethod()
        {
            return new Car()
            {
                Color = "Red",
                Wheels = 4
            };
        }
    }
}
