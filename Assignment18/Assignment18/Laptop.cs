using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Laptop : IConnectable, IRechargeable, IDisplayable
    {
        string Model;
        bool IsConnected;
        //public string Model { get; set; }
        //public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }
         
        public Laptop(string model)
        {
            Model = model;
            BatteryLevel = 30;
        }

        public bool Connect()
        {
          Console.WriteLine($"{Model} is connecting to the Network....\n");
            IsConnected = true;
            Console.WriteLine($"Device is  successfully connected!!");
            return true;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"Charging for {minutes} minutes.");
          
            BatteryLevel += minutes / 3;
            if (BatteryLevel > 100)
                BatteryLevel = 100;
        }

        public void Display()
        {
            Console.WriteLine($"BatterLevel: {BatteryLevel}% \nConnectivity Status: {IsConnected}");
        }
    }
}
