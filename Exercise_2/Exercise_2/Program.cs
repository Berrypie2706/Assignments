using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            char gender;
            double salary;
            DateTime DOJ;

            Console.WriteLine("Enter id");
            id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name");
            name = Console.ReadLine();
           
            Console.WriteLine("Enter gender");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter salary");
            salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of joining");
            DOJ = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ID : \t" + id + "\n NAME: " + name + "\n Gender: \t " + gender + "\n salary: \t  " + salary + "\n Date of joining: \t " + DOJ);
            Console.WriteLine("Your Salary is" + salary);
           
            if (salary > 90000)
            {
                Console.WriteLine("You have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("Tax will be 15%"); 
            }
           
          
            Console.ReadKey();


        }
    }
}
