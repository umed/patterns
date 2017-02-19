using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            //source object
            IPrototype prototype = new TruckPrototype();


            const int sampleCount = 10;

            //serial objects
            List<IPrototype> list = new List<IPrototype>();

            for (int i = 0; i < sampleCount; i++)
                list.Add(prototype.Clone());
        }
    }
}
