using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            ab.Implementor = new ConcreteImplementorFirst();
            ab.Operation();

            ab.Implementor = new ConcreteImplementorSecond();
            ab.Operation();
        }
    }
}
