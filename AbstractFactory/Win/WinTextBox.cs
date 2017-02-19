using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Win
{
    class WinTextBox : ITextBox
    {
        public string Text { get; set; }
    }
}
