using Assignment9;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment9
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            //            Your task is to implement exception handling for validation errors in a user registration system.The program should meet the following requirements:

            //User Registration: The program should allow users to register by providing their name, email, and password.

            //Validation: The program should validate the user input and check for any invalid or missing values.

            //Custom Exception: If any validation error occurs, the program should throw a custom exception called Validation Exception with a meaningful error message.

            //Exception Handling: The program should catch the other Exception and display the error message to the user.


            //        Instructions:

            //            Create a new console application project in programming language C#.
            //Implement the logic to prompt the user to enter their name, email, and password.

            //user name must have at least 6 characters and password must have at least 8 characters.

            //Validate the user input to ensure that all required fields are provided and they meet certain criteria(e.g., password length, user name length, etc.).

            //If any validation error occurs, throw a custom exception called ValidationException with an appropriate error message.

            //Catch the ValidationException and display the error message to the user.

            //If the input is valid, display a success message to the user.user registration success , Plus al insert details as well.



            string choice;
            do
            {
                try
                {
                    string userName, email, password;

                    Console.Write("Enter User Name:");
                    userName = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.Write("Enter email:");
                    email = Console.ReadLine();
                    Console.WriteLine("\n");
                    Console.Write("Enter Password:");
                    password = Console.ReadLine();
                    Console.WriteLine("\n");

                    if (userName.Length < 6 && password.Length < 8)
                    {
                        Console.WriteLine("USER NAME SHOULD HAVE ATLEAST 6 CHARACTERS && PASSWORD SHOULD HAVE ATLEAST 8 CHARACTERS");

                    }

                    else if (userName.Length < 6)
                    {
                        throw new ValidationException("User name should have atleast 6 characters");

                    }

                    else if (password.Length < 8)
                    {
                        throw new ValidationException("Password should have atleast 8 characters");

                    }

                    else
                    {
                        Console.WriteLine("****Registration Successfull");
                        Console.WriteLine($"User Name : {userName} \nEmail : {email} \nPassword : {password}");
                    }

                }
                catch (ValidationException e)
                {
                    Console.WriteLine(" ValidationException : " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!" + e.Message);
                }
                Console.WriteLine("Do you wanna continue if yes press y \nTo exit press any key");
                choice = Console.ReadLine().ToLower();
            }
            while (choice == "y");
            Console.ReadKey();
        }
    }
}




   

        






      
