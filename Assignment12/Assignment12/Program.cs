using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment12
{
          internal class Program
    {
        static void Main(string[] args)
        {
            InputValidation inputValidation = new InputValidation();
            Console.WriteLine("Enter Text:");
            string inputText = Console.ReadLine();
            int count = inputValidation.CountWords(inputText);
            Console.WriteLine("Word Counts:"+count);

            var emailAddresses = inputValidation.EmailValidation(inputText);
            Console.WriteLine($"Email address found: {emailAddresses}");
            foreach( var emailAddress in emailAddresses )
            {
                Console.WriteLine(emailAddress);
            }

            var mobileNumbers = inputValidation.IsMobileValid(inputText);
            Console.WriteLine($"Mobile numbers found: {mobileNumbers}");
            foreach( var mobileNumber in mobileNumbers)
            {
                Console.WriteLine(mobileNumber);
            }

            Console.WriteLine("\nEnter a custom regular expression:");
            string customRegexPattern = Console.ReadLine();

            var customRegexMatches = inputValidation.PerformRegexSearch(inputText, customRegexPattern);
            Console.WriteLine("\nCustom regex matches found:");
            foreach (var match in customRegexMatches)
            {
                Console.WriteLine(match);
            }


            Console.ReadKey();  

        }


        }
    }
    


