using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Grapes", "Orange", "Pineapple", "Strawberry", "Watermelon", "Mango", "Kiwi" };
            List<string> days = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            List<string> months = new List<string> { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

         
            Dictionary<string, string> dictionary = new Dictionary<string, string>
        {
            { "Apple", "A round fruit with red or green skin and white flesh" },
            { "Banana", "A long, curved fruit with yellow skin" },
            { "Cherry", "A small, round fruit with red or black skin and a stone inside" },
            { "Grapes", "Small, sweet fruits growing in bunches" },
            { "Orange", "A round fruit with orange skin and sweet, juicy flesh" }
        };

            Console.WriteLine(".........Welcome to Learning............");

  
            Thread daysThread = new Thread(() =>
            {
                foreach (string day in days)
                {
                    Console.WriteLine($"Day: {day}");
                    Thread.Sleep(2000); 
                }
            });

           
            Thread monthsThread = new Thread(() =>
            {
                Thread.Sleep(5000); 
                foreach (string month in months)
                {
                    Console.WriteLine($"Month: {month}");
                    Thread.Sleep(2000); 
                }
            });

           
            Thread fruitsAndDictionaryThread = new Thread(() =>
            {
                //foreach(string fruit in fruits)
                //{
                //    Console.WriteLine($"Fruits :{fruits}");
                //}

                //foreach (string dic in Dictionary.Keys)
                //{

                //}
                int index = 0;
                while (true)
                {
                    Console.WriteLine($"Fruit: {fruits[index]}");

                    if (dictionary.ContainsKey(fruits[index]))
                    {
                        Console.WriteLine($"Meaning: {dictionary[fruits[index]]}");


                        Thread.Sleep(3000);

                        index = (index + 1) % fruits.Count;
                    }
                }
            });

        
            daysThread.Start();
            monthsThread.Start();
            fruitsAndDictionaryThread.Start();

           
            //daysThread.Join();
            //monthsThread.Join();
            //fruitsAndDictionaryThread.Join();

            Console.WriteLine("End of Learning!");
        }
    }
}
   
