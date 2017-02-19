using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractMethod.Interfaces;

namespace AbstractMethod.Vehicles
{
    class Truck : IVehicle
    {
        public string Color { get; set; }
        public int Wheels { get; set; }
    }
}
