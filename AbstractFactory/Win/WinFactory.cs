using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Win
{
    class WinFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ITextBox CreateTextBox()
        {
            return new WinTextBox()
            {
                Text = "I'm Win TextBox"
            };
        }
    }
}
