using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IVehicleBuilder
    {
        void SetColor(string color);
        void SetWheels();
        void SetType();
        Vehicle GetResult();
    }
}
