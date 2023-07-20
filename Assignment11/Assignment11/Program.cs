using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> initialData = new List<int> { 1, 2, 3, 4, 5, 6, 7, 60, 70, 80, 90, 100, 110, 120 };
                LargeDataCollection<int> largeDataCollection = new LargeDataCollection<int>(initialData);
                largeDataCollection.Add(130);
                largeDataCollection.Add(140);
                largeDataCollection.Add(150);
                Console.WriteLine("The list after Adding The Elements");
                largeDataCollection.showData();
                Console.WriteLine("\n");

                //removing elements

                largeDataCollection.Remove(1);
                largeDataCollection.Remove(150);
                largeDataCollection.Remove(90);

                //Accessing List After Removing elements
                Console.WriteLine("The Updated list after Removing The Elements");
                largeDataCollection.showData();
                Console.WriteLine("\n");

                //calling the `Dispose` method explicitly

                Console.WriteLine("*****Calling the Dipose method to Release the resources of the collection.******* \n");
              
                largeDataCollection.Dispose();
                Console.WriteLine("\n");
                largeDataCollection.showData();
               
            } catch (NullReferenceException e) 
            {
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
                Console.WriteLine("---->>>\tNull Reference exception: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!!!" + e.Message);
            }

          
            Console.ReadKey();

        }
    }
}
