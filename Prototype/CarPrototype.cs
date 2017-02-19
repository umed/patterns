using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class TruckPrototype : IPrototype
    {
        public IPrototype Clone()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
