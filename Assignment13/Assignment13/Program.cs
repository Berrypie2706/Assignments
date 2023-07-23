using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class myMethod
    {
        public long CalculateFactorial(int num)

        {
            long factorial = 1;
            for (int i = 2; i < num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        internal class Program
        {
            static void Main(string[] args)
            {

                //Task1
                Console.WriteLine("HEllo, World!");

                //Task 2


                Console.WriteLine("Enter Name:");
                string name = Console.ReadLine();
                Console.WriteLine($"Hello,{name}");

                //Task3

                Console.WriteLine("Enter First number:");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter second number:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Choose the Operations");
                int operations = int.Parse(Console.ReadLine());
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Substraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Modulus");
                double res;

                switch (operations)
                {
                    case 1:
                        res = num1 + num2;
                        Console.WriteLine("Addition Result:" + res);
                        break;

                    case 2:
                        res = num1 - num2;
                        Console.WriteLine("Substraction result: " + res);
                        break;

                    case 3:
                        res = num1 * num2;
                        Console.WriteLine("Multiplication result: " + res);
                        break;

                    case 4:
                        res = num1 / num2;
                        if (num1 == 0 || num2 == 0)
                        {
                            Console.WriteLine("Can't divide by zero");
                        }
                        else
                        {
                            Console.WriteLine("Division Result: " + res);
                        }
                        break;

                    case 5:
                        res = num1 % num2;
                        Console.WriteLine("Modulus Result: " + res);
                        break;
                    default:
                        Console.WriteLine("Please enter the number");
                        break;
                }
                Console.ReadKey();

                //Task 4 

                if (num1 % 2 == 0 || num2 % 2 == 0)
                {
                    Console.WriteLine("Number is even");
                }
                else
                {
                    {
                        Console.WriteLine("Number is odd");
                    }
                }

                //Task5 

                Console.WriteLine("Numbers from 1 to 10:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }

                // Task 6

                int[] array = new int[5] { 1, 2, 3, 4, 5 };
                int sum = 0;

                for (int i = 0; i < array.Length; i++)
                {

                    sum = sum + array[i];


                }
                Console.WriteLine("The sum of array elements:" + sum);
                double avg = sum / array.Length;
                Console.WriteLine("The average of array elements :" + avg);

                //Task 7

                myMethod fact = new myMethod();
                Console.WriteLine($"The factorial is : {fact}");

                //Task 8


                //  use the tryparse method to convert a string to an integer
                string choice;
                do
                {
                    try
                    {
                        Console.WriteLine("Enter Your Age:");
                    Again:
                        string input = Console.ReadLine();


                        if (int.TryParse(input, out int number))
                        {
                            if (number < 18)
                            {
                                Console.WriteLine("You are Minor!!");

                            }
                            else if (number >= 18 && number < 65)
                            {
                                Console.WriteLine("You Are Adult!!");


                            }
                            else
                            {
                                Console.WriteLine("You Are Senior Citizen!!");

                            }

                        }
                        else
                        {
                            Console.WriteLine("error: invalid input. unable to convert to an integer.");
                            Console.WriteLine("Enter a Valid input again!!!");

                            goto Again;
                        }
                    }


                    catch (FormatException ex)
                    {
                        Console.WriteLine("Format Exception" + ex.Message);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine("Error!!!!" + ex.Message);
                    }
                    choice = Console.ReadLine();
                    Console.WriteLine("Press Y to Enter again Or Press Any Other Key To Exit!!");
                }
                while (choice == "y" || choice == "Y");
                Console.ReadKey();



            }
        }
    }
}



