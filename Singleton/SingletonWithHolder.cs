using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonWithHolder
    {
        private SingletonWithHolder() { }

        private class InstanceHolder
        {
            private static readonly SingletonWithHolder _instance = new SingletonWithHolder();

            public static SingletonWithHolder Instance
            {
                get
                {
                    return _instance;
                }
            }
        }

        public static SingletonWithHolder Instance
        {
            get
            {
                return InstanceHolder.Instance;
            }
        }

        public void DoSomething()
        {
            //TODO: ???
        }
    }
}
