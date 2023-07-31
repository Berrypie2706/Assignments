using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment19
{
    public delegate void ArithmeticOperation(double n1, double n2);
    internal class Program
    {
     
        public static void Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Result: \t " + result);
        }

        public static void Substract(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Result: \t " + result);
        }

        public static void Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine("Result: \t " + result);
        }

        public static void Divide(double num1, double num2)
        {
            double result = num1 / num2;
            Console.WriteLine("Result: \t " + result);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Choose the Operation");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Difference");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            int operation = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first Integer or float value:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first Integer or float value:");
            int num2 = int.Parse(Console.ReadLine());

           
          
                switch (operation)
                {
                    case 1:
                        {
                            ArithmeticOperation ap = new ArithmeticOperation(Program.Add);
                            ap(num1, num2);
                            break;
                        }
                    case 2:
                        {
                            ArithmeticOperation ap1 = new ArithmeticOperation(Program.Substract);
                            ap1(num1, num2);
                            break;
                        }
                    case 3:
                        {
                            ArithmeticOperation ap2 = new ArithmeticOperation(Program.Multiply);
                            ap2(num1, num2);
                            break;
                        }
                    case 4:
                        {
                            ArithmeticOperation ap3 = new ArithmeticOperation(Program.Divide);
                            ap3(num1, num2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choose valid operation");
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Went Wrong!!!" + ex.Message);
            }
            
                         
                      Console.ReadKey();
        }
    }
}
