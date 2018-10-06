using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();

            //emp.

            IPrintable empPrint = new Employee();
            empPrint.Print();
            empPrint.Show();

            IDisplay empDisp = new Employee();
            empDisp.Display();
            empDisp.Show();

            Console.ReadKey();
        }
    }
}
