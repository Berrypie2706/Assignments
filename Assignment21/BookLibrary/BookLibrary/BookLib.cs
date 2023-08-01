using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BookLibrary
{
    public class BookLib
    {
        static List<Book> library;
        public BookLib()
        {
            library = new List<Book>()
            {
                new Book() {BookId = 001,Title = "To Kill a MockingbirdAuthor", Author =  "Harper Lee", Genre = "Fiction, Classic, Coming-of-age" },
                new Book() {BookId = 002,Title = "1984", Author =  " George Orwell", Genre = "Fiction, Dystopian, Political" },
                new Book() {BookId = 003,Title = "The Great Gatsby", Author =  "F. Scott Fitzgerald", Genre = "Fiction, Classic, Romance" },
                new Book() {BookId = 004,Title = "Pride and Prejudice", Author =  "Jane Austen", Genre = " Fiction, Classic, Romance" },
                new Book() {BookId = 005,Title = " The Lord of the Rings", Author =  " J.R.R. Tolkien", Genre = "Fantasy, Adventure" },
                new Book() {BookId = 006,Title = "Harry Potter and the Sorcerer's Stone", Author =  "J.K. Rowling", Genre = " Fantasy, Young Adult" },
              

            };
        }

        public void Print()
        {
            foreach (Book book in library)
            {
                Console.WriteLine("Book ID: \t" + book.BookId);
                Console.WriteLine("Title: \t" + book.Title);
                Console.WriteLine("Author: \t" + book.Author);
                Console.WriteLine("Genre: \t" + book.Genre);

            }
        }

        public void AddBook(Book book)
        {
            library.Add(book);
            Console.WriteLine("Updated Library");
            this.Print();
        }

        public void searchBookById(int bookid)
        {
            var book = library.Find(b => b.BookId == bookid);
            if (book != null)
            {
                Console.WriteLine("Book is Available");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Book ID: \t" + book.BookId);
                Console.WriteLine("Title: \t" + book.Title);
                Console.WriteLine("Author: \t" + book.Author);
                Console.WriteLine("Genre: \t" + book.Genre);

            }

            else
            {
                Console.WriteLine("Not available");
            }
        }
         public void searchBookByTitle(string title)
          {
                    
            var book = library.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {

                Console.WriteLine("Book is Available");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Book ID: \t" + book.BookId);
                Console.WriteLine("Title: \t" + book.Title);
                Console.WriteLine("Author: \t" + book.Author);
                Console.WriteLine("Genre: \t" + book.Genre);
            }
                
                else
                {
                    Console.WriteLine("Not available");
                }
            }

        }
    }

