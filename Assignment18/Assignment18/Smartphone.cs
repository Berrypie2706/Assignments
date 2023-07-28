using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        string Model;
        bool IsConnected;
        
        //public string Model { get; set; }
        //public bool IsConnected { get; private set; }
        public int BatteryLevel { get; private set; }
    
        public Smartphone(string model)
        {
            Model = model;
            BatteryLevel = 0;
        }

        public bool Connect()
        {
            Console.WriteLine($"{Model}  connecting to the Network....!!!");
            IsConnected = true;
            Console.WriteLine($"Device is successfully connected!!");
            return true;
        }

        public void Charge(int minutes)
        {
            Console.WriteLine($"Charging for {minutes} minutes.");

            BatteryLevel += minutes /2;
            if (BatteryLevel > 100)
                BatteryLevel = 100;
           
        }

        public void Display()
        {
            Console.WriteLine($"BatterLevel: {BatteryLevel}% \nConnectivity Status: {IsConnected}"); 
        }
    }
}
