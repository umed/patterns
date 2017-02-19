﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Abstraction
    {
        public Implementor Implementor { get; set; }

        public virtual void Operation()
        {
            Implementor.Operation();
        }
    }
}
