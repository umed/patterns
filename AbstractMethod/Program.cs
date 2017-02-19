using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractMethod.Interfaces;
using AbstractMethod.Creators;

namespace AbstractMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreator[] creators = new ICreator[] { new CarCreator(), new TruckCreator() };
            foreach(var creator in creators)
            {
                IVehicle vehicle = creator.FactoryMethod();
                Console.WriteLine("Type" + vehicle.GetType());
            }
        }
    }
}
