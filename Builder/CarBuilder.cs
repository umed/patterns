﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class CarBuilder : IVehicleBuilder
    {
        private readonly Vehicle _vehicle = new Vehicle();

        public const int Wheels = 4;
        public const string Type = "Car";

        public void SetColor(string color)
        {
            if (String.IsNullOrEmpty(color))
                throw new ArgumentException();
            _vehicle.Color = color;
        }

        public void SetWheels()
        {
            _vehicle.Wheels = Wheels;
        }

        public void SetType()
        {
            _vehicle.Type = Type;
        }

        public Vehicle GetResult()
        {
            return _vehicle;
        }
    }
}
