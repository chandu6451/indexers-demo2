using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    public class Employee : IPrintable, IDisplay
    {
        void IPrintable.Print()
        {
            Console.WriteLine("Employee Class implemented Print Method of IPrintable");
        }

        void IPrintable.Show()
        {
            Console.WriteLine("Employee Class implemented Show Method of IPrintable");
        }

        void IDisplay.Display()
        {
            Console.WriteLine("Employee Class implemented Display Method of IDisplay");
        }

        void IDisplay.Show()
        {
            Console.WriteLine("Employee Class implemented Show Method of IDisplay");
        }
    }
}
