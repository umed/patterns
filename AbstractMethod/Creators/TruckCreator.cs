using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractMethod.Interfaces;
using AbstractMethod.Vehicles;

namespace AbstractMethod.Creators
{
    class TruckCreator : ICreator
    {
        public IVehicle FactoryMethod()
        {
            return new Truck()
            {
                Color = "Blue",
                Wheels = 6
            };
        }
    }
}
