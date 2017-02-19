using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.OSX
{
    class OSXFactory:IFactory
    {
        public IButton CreateButton()
        {
            return new OSXButton();
        }

        public ITextBox CreateTextBox()
        {
            return new OSXTextBox()
            {
                Text = "I'm OSX TextBox!"
            };
        }
    }
}
