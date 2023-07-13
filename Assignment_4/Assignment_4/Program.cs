using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            //Write a C# program that prompts the user to enter a number.
            //            Implement decision-making constructs to perform the following tasks:
            //a.If the number is positive, display "The number is positive."
            //b.If the number is negative, display "The number is negative."
            //c.If the number is zero, display "The number is zero."
            //Utilize the conditional operator to determine whether the number is even or odd.
            //a.If the number is even, display "The number is even."
            //b.If the number is odd, display "The number is odd."


            int num;
            Console.WriteLine("Enter number");
            num = int.Parse(Console.ReadLine());
            if(num> 0)
            {
                Console.WriteLine("Number is positive");
            }
           else if(num<0) {
                Console.WriteLine("Number is negative");
            }
            else
            {
                Console.WriteLine("Number is zero");
            }


            //Utilize the conditional operator to determine whether the number is even or odd.
            //(Condition) ? true case : false case
            var res = (num % 2 == 0) ? "Number is even" : "Number is odd";
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
