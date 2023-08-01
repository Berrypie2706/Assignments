using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;

namespace Assignment21
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Choose from below:");
                Console.WriteLine("1. View Book Library \n 2. Add Book \n " +
                    "3. Search Book By Title \n 4. Search Book By ID");

                int a = int.Parse(Console.ReadLine());
                BookLib bookLib = new BookLib();

                switch (a)
                {
                    case 1:
                        {
                           
                                bookLib.Print();                            
                                break;
                        }
                    case 2:
                        {
                            try
                            {
                                Book book = new Book();
                                Console.WriteLine("Enter Book Id, Book Title, Book Author, Book Genre:");
                                book.BookId = int.Parse(Console.ReadLine());
                                book.Title = Console.ReadLine();
                                book.Author = Console.ReadLine();
                                book.Genre = Console.ReadLine();
                                bookLib.AddBook(book);
                            }
                            catch(FormatException e)
                            {
                                Console.WriteLine("Format Exception:" + e.Message);
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("SomeThing Went Wrong:" +e.Message);
                            }
                          
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the Book Title You Want To Search");
                            Book book = new Book();
                            book.Title = Console.ReadLine();
                            bookLib.searchBookByTitle(book.Title);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter the Book ID You Want To Search");
                            Book book = new Book();
                            book.BookId = int.Parse(Console.ReadLine());
                            bookLib.searchBookById(book.BookId);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Operation");
                            break;
                        }

                }
                Console.WriteLine("Press Y to Continue Otherwise Press Enter To Exit");
                choice = Console.ReadLine();
            }
 
            while (choice == "Y" || choice == "y");
            Console.ReadKey();
            }
        }
    }

