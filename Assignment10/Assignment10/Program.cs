using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {                
                try
                {
                    FileHandling file = new FileHandling();
                    Console.WriteLine("Choose operation:");
                    Console.WriteLine("1. Create");
                    Console.WriteLine("2. Read");
                    Console.WriteLine("3. Append");
                    Console.WriteLine("4. Delete");

                    int operations = int.Parse(Console.ReadLine());

                    switch (operations)
                    {
                        case 1:
                            Console.WriteLine("Enter File name");
                            string filename = Console.ReadLine();
                            Console.WriteLine("Enter the content");
                            string content = Console.ReadLine();
                            file.Create(filename, content);
                            break;

                        case 2:
                            Console.WriteLine("Enter The Name Of the File you Want To Read");
                            string readFilename = Console.ReadLine();
                            file.Read(readFilename);
                            break;

                        case 3:
                            Console.WriteLine("Enter the File Name to Append");
                            string appendFile = Console.ReadLine();
                            Console.WriteLine("Enter The Text You Want To Append");
                            string appendedText = Console.ReadLine();
                            file.AppendToFile(appendFile, appendedText);
                            break;

                        case 4:
                            Console.WriteLine("Enter the File Name You Want To Delete");
                            string Delete = Console.ReadLine();
                            file.DeleteFile(Delete);
                            break;


                    }
                }
                catch (FormatException e)
                {


                    Console.WriteLine("Format Exception:" + e.Message);



                }
                catch (Exception e) { Console.WriteLine("Incorrect input" + e.Message); }

                Console.WriteLine("Press X If You Want To Retry.");

                Console.WriteLine("Press Any Key To Exit!!!!");
                choice = Console.ReadLine();
            }
            while (choice== "x" || choice=="X");
        }    
    }
    
}

