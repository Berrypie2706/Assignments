using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class Salary
    {
        public double CalculateMonthlySalary(int projectHandles=1, int extras =0)
        {
            int working_Hours, noOfWorking_Days;

            //asking user to enter details
            Console.WriteLine("Enter number of working hours:");
            working_Hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of working days:");
            noOfWorking_Days = Convert.ToInt32(Console.ReadLine());

            return (working_Hours + noOfWorking_Days * 100) + (projectHandles * 3000) + (extras * 2000);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Salary calculation system");
            Console.WriteLine("Choose employee type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software developer");

            Salary calculate = new Salary();
            string employeeType = Console.ReadLine();

            //int workingHours, noOfWorkingDays, projectHandles = 1, extras = 0;

            ////asking user to enter details
            //Console.WriteLine("Enter number of working hours:");
            //workingHours = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter number of working days:");
            //noOfWorkingDays = Convert.ToInt32(Console.ReadLine());

            //Prompt user to enter specific details
            switch (employeeType)
            {
                case "HR":
                    //projectHandles = 1;
                    //extras = 0;
                    Console.WriteLine($"Monthly salary of{employeeType}: "+calculate.CalculateMonthlySalary());

                    break;


                case "Admin":
                    Console.WriteLine("Enter number of project handles:");
                    int projectHandles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Monthly salary of{employeeType} : " + calculate.CalculateMonthlySalary());
                    break;

                case "SoftwareDeveloper":
                    Console.WriteLine("Enter number of project handles:");
                    projectHandles = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter extra:");
                    int extras = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Monthly salary of{employeeType}: " + calculate.CalculateMonthlySalary());
                    break;

                default:

                    Console.WriteLine("Invalid Employee type");
                    break;
            }
            //Salary calculate = new Salary();
            //double monthlySalary = calculate.CalculateMonthlySalary(workingHours, noOfWorkingDays, projectHandles, extras);
            //Console.WriteLine($"Monthly salary :" + monthlySalary);
            Console.ReadKey();
        }
    }
}