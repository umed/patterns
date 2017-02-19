using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.OSX
{
    class OSXTextBox : ITextBox
    {
        public string Text { get; set; }
    }
}
