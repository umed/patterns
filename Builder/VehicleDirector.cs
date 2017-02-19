using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class VehicleDirector
    {
        /// <summary>
        /// Construct returns nothing, another variant when Construct return constructed object
        /// </summary>
        /// <param name="builder"></param>
        public void Construct(IVehicleBuilder builder)
        {
            builder.SetColor("Red");
            builder.SetWheels();
            builder.SetType();
        }
    }
}
