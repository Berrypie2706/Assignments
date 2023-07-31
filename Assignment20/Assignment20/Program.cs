using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Description;

namespace Assignment20
{
    public delegate T Operation<T>(T n1, T n2);
    public class Program
    {

        public static T Add<T>(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num1;

            return (T)Convert.ChangeType(n1 + n2, typeof(T));
        }
        public static T Substract<T>(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num1;

            return (T)Convert.ChangeType(n1 - n2, typeof(T));
        }
        public static T Multiply<T>(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num1;

            return (T)Convert.ChangeType(n1 * n2, typeof(T));
        }
        public static T Divide<T>(T num1, T num2)
        {
            dynamic n1 = num1;
            dynamic n2 = num1;

            return (T)Convert.ChangeType(n1 / n2, typeof(T));
        }



        static void Main(string[] args)
        {
            string choice;

            do 
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
                    string num1 = Console.ReadLine();
                    Console.WriteLine("Enter first Integer or float value:");
                    string num2 = Console.ReadLine();

                    int intValue1, intValue2;
                    double doubleValue1, doubleValue2;
                    switch (operation)
                    {

                        case 1:
                            {
                                if (int.TryParse(num1, out intValue1) && int.TryParse(num2, out intValue2))
                                {
                                    Operation<int> addInt = (x, y) => Add(x, y);
                                    Console.WriteLine($"Addition: {addInt(intValue1, intValue2)}");

                                }
                                else if (double.TryParse(num1, out doubleValue1) && double.TryParse(num2, out doubleValue2))
                                {
                                    Operation<double> addDouble = (x, y) => Add(x, y);
                                    Console.WriteLine($"Addition: {addDouble(doubleValue1, doubleValue2)}");
                                }
                                break;
                            }
                        case 2:
                            {
                                if (int.TryParse(num1, out intValue1) && int.TryParse(num2, out intValue2))
                                {
                                    Operation<int> subtractInt = (x, y) => Substract(x, y);
                                    Console.WriteLine($"Subtraction: {subtractInt(intValue1, intValue2)}");

                                }
                                else if (double.TryParse(num1, out doubleValue1) && double.TryParse(num2, out doubleValue2))
                                {
                                    Operation<double> subtractDouble = (x, y) => Substract(x, y);
                                    Console.WriteLine($"Subtraction: {subtractDouble(doubleValue1, doubleValue2)}");
                                }
                                break;
                            }

                        case 4:
                            {
                                if (int.TryParse(num1, out intValue1) && int.TryParse(num2, out intValue2))
                                {
                                    Operation<int> divideInt = (x, y) => Divide(x, y);
                                    Console.WriteLine($"Division: {divideInt(intValue1, intValue2)}");

                                }
                                else if (double.TryParse(num1, out doubleValue1) && double.TryParse(num2, out doubleValue2))
                                {
                                    Operation<double> divideDouble = (x, y) => Divide(x, y);
                                    Console.WriteLine($"Division: {divideDouble(doubleValue1, doubleValue2)}");
                                }
                                break;
                            }
                        case 3:
                            {
                                if (int.TryParse(num1, out intValue1) && int.TryParse(num2, out intValue2))
                                {
                                    Operation<int> multiplyInt = (x, y) => Multiply(x, y);

                                    Console.WriteLine($"Multiplication: {multiplyInt(intValue1, intValue2)}");

                                }
                                else if (double.TryParse(num1, out doubleValue1) && double.TryParse(num2, out doubleValue2))
                                {
                                    Operation<double> multiplyDouble = (x, y) => Multiply(x, y);
                                    Console.WriteLine($"Multiplication: {multiplyDouble(doubleValue1, doubleValue2)}");
                                }
                                break;
                            }
                        default: throw new ArgumentException();

                    }

                }
                catch (Exception e) { Console.WriteLine(e.Message); }
                Console.WriteLine("Press y to do again and any key to exit !!!");
               choice = Console.ReadLine();
            }
            while(choice == "y" || choice == "Y");
            Console.ReadKey();
        }
        
    }
}
            


                      


                           
                   
                    

                   
                  
             

    






        
    

