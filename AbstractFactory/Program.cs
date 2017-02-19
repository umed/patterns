using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;
using AbstractFactory.OSX;
using AbstractFactory.Win;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose OS:");
            Console.WriteLine("1. Win");
            Console.WriteLine("2. OS X");

            string result = Console.ReadLine();
            IFactory factory;

            switch (result)
            {
                case "1":
                    factory = new WinFactory();
                    break;
                case "2":
                    factory = new OSXFactory();
                    break;
                default:
                    throw new NotImplementedException();
            }

            IButton button = factory.CreateButton();

            ITextBox textBox = factory.CreateTextBox();
        }
    }
}
