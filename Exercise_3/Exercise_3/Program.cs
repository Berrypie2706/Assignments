using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercisse 3

            //Use the TryParse method to convert a string to an integer
            //Console.WriteLine("Enter a number");
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("TryParsed integer is : " + number);

            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input. Unable to convert to an integer.");
            //}
            //Console.ReadKey();




            //Use the Convert method to convert a string to a double.
            //Handle any exceptions that may occur during the
            //conversion and print an appropriate error message.
            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    string input1 = Console.ReadLine();
            //    int convertedDouble = (int)Convert.ToDouble(input1);
            //    Console.WriteLine("Double is:" +  convertedDouble);
            //} 
            //catch (FormatException ex) 
            //{
            //    Console.WriteLine("Error Converting!!! " + ex.Message);
            //}
            //catch(OverflowException ex)
            //{
            //    Console.WriteLine("Overflow exception" + ex.Message);
            //}
            //catch(Exception ex) 
            //{
            //    Console.WriteLine("Exception error" + ex.Message);
            //}
            //finally 
            //{
            //    Console.WriteLine("End of Program!!!");
            //    Console.ReadLine();

            // }
            //Console.ReadKey();





            //Use the Parse method to convert a string to a decimal.
            //Handle any exceptions that may occur during the conversion and
            //print an appropriate error message.

            //try
            //{
            //    Console.WriteLine("Enter a number");
            //    string input1 = Console.ReadLine();
            //    decimal num = decimal.Parse(input1);

            //    Console.WriteLine("Converted string into decimal :" + num);

            //}
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine("ArgumentNullException" + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Format exception" + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Exception error" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("End of program");
            //    Console.ReadKey();
            //}
            //Console.ReadKey();





            //Convert a string to an integer using the TryParse method.
            //If the conversion is successful, multiply the resulting integer by 5
            //and print the final value; otherwise, display an error message.


            //Console.WriteLine("Enter a number");
            //string input = Console.ReadLine();
            //if (int.TryParse(input, out int number))
            //{
            //    Console.WriteLine("Tryparsed integer is : " + number *5);

            //}
            //else
            //{
            //    Console.WriteLine("error: invalid input. unable to convert to an integer.");
            //}
            //Console.ReadKey();






            //Convert a string to a DateTime object using the Convert method.
            //Handle any exceptions that may occur during the conversion and
            //print an appropriate error message. Then, subtract 1 month from
            //the obtained DateTime object and display the result.

            //try
            //{
            //    Console.WriteLine("Enter a Date(DD/MM/YYYY)");
            //    string input = Console.ReadLine();
            //    DateTime datetime = Convert.ToDateTime(input);
            //    Console.WriteLine($"Original date :" + datetime);
            //    DateTime newDate = datetime.AddMonths(-1);
            //    Console.WriteLine($"New date after substracting 1 Month from the original date : { newDate.ToShortDateString()}");

            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Invalid input. PLease enter a date in a specified format(MM/DD/YY)" + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error occured !!!" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("End of program!!!");
            //    Console.ReadLine();

            //}
            //Console.ReadLine();






            //Convert a string to a TimeSpan object using the Parse method. Handle any exceptions that may
            //occur during the conversion and
            //print an appropriate error message. Then, add 2 hours to the obtained TimeSpan object and display the result.

            try
            {
                Console.WriteLine("Enter a Timespan(hh:mm:ss)");
                string timeSpan = Console.ReadLine();
                TimeSpan T1 = TimeSpan.Parse(timeSpan);
                Console.WriteLine($"Original timespan : is{T1}");
                TimeSpan T2 = T1.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine($"New time span : {T2}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter in the correct format");

            }
            catch (OverflowException)
            {
                Console.WriteLine("The entered time span is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured" + ex.Message);

            }
            Console.ReadKey();


        }
    }
}
