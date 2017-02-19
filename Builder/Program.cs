using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBuilder builder = new CarBuilder();

            VehicleDirector director = new VehicleDirector();

            director.Construct(builder);

            Vehicle vehicle = builder.GetResult();

            Console.WriteLine("Type: " + vehicle.Type);
            Console.WriteLine("Color: " + vehicle.Color);
            Console.WriteLine("Wheels: " + vehicle.Wheels);
        }
    }
}
