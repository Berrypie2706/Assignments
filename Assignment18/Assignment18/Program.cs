using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Black Berry");
            Laptop laptop = new Laptop("MacBook");

            smartphone.Connect();
            smartphone.Charge(100);
            smartphone.Display();
          
            Console.WriteLine("\n*************************************************************************************************8");

            laptop.Connect();
            laptop.Charge(120);
            laptop.Display();
        }
    }
}
