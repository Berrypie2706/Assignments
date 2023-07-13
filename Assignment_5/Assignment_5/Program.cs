using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Write a C# program to create a simple login system.
            //Implement decision - making constructs to perform the following tasks:
            //a.Prompt the user to enter a username and password.
            //b.If both the username and password are correct, display "Login successful."
            //c.If the username is correct but the password is incorrect, display "Invalid password."
            //d.If the username is incorrect, display "Invalid username."
            //If the user fails to provide the correct login credentials within
            //three attempts, terminate the program and display "Login failed."


            string validUserName = "admin1307";
            string validPassword = "admin@1307";
            int remainingAttempts = 3;
            
            while (remainingAttempts > 0)
            {
                string userName, password;
                Console.Write("Enter UserName");
                userName = Console.ReadLine();
                Console.Write("Enter Password");
                password = Console.ReadLine();

                if (userName == validUserName && password == validPassword)
                {
                    Console.WriteLine("Login successfull");
                    break;


                }
                else if (userName == validUserName)
                {
                    Console.WriteLine("Invalid Password");
                }
                else
                {
                    Console.WriteLine("Invlaid Username");
                }
                remainingAttempts--;
                Console.WriteLine();
            }
            Console.WriteLine("Login failed");
           
            Console.ReadKey();
            }

        }
   }

