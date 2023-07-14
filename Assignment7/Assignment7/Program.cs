using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Task:
            //            Create an ArrayList and add the following elements to it: "apple," "banana," "cherry," "date," "elderberry."

            //Print the total number of elements in the ArrayList. Write the code to insert,remove and search items from the list.
            //Sample Task to check Input Output: 
            //Check if the ArrayList contains the element "date" and print the result.
            //Insert the element "fig" at the second position in the ArrayList.
            //Remove the element "banana" from the ArrayList.
            //Print all the elements in the ArrayList using a loop.

            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine("How many items you want to add?");
            //int noOfItems = int.Parse(Console.ReadLine());
            //string item;

            //Console.WriteLine("Enter item you want to add");
            //for (int i = 0; i < noOfItems; i++)
            //{
            //    item = Console.ReadLine();
            //    arrayList.Add(item.ToLower());

            //}
            //Console.WriteLine("List of items: \n");
            //foreach (var i in arrayList)
            //{
            //    Console.WriteLine(i);

            //}

            ////Check if the ArrayList contains the element "date" and print the result.
            //Console.WriteLine("Check if the ArrayList contains the element \"date\" and print the result.\n");
            //Console.WriteLine("Enter the name of the item you want to search:\n");


            //for (int i = 0; i < noOfItems; i++)
            //{

            //    string search = Console.ReadLine();
            //    bool itemExists = arrayList.Contains(search.ToLower());
            //    if (itemExists)
            //    {
            //        Console.WriteLine($"The Item '{search}' is at position {i+1} in the list.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not found");
            //    }


            //    // Insert the element "fig" at the second position in the ArrayList.
            //    Console.WriteLine("Insert the element \"fig\" at the second position in the ArrayList.");
            //    Console.WriteLine("Enter the item you want to insert");

            //    string addItem = Console.ReadLine();
            //    Console.WriteLine("In which position you want to insert");
            //    int pos = int.Parse(Console.ReadLine());
            //    arrayList.Insert(pos - 1, addItem.ToLower());
            //    Console.WriteLine("Updated lists of fruits");
            //    foreach (string a in arrayList)
            //    {
            //        Console.WriteLine(a);
            //    }

            //    //Remove the element "banana" from the ArrayList
            //    Console.WriteLine("Remove the element \"banana\" from the ArrayList\n");
            //    Console.WriteLine("Enter the item you want to remove:\n");
            //    string removeItem = Console.ReadLine();

            //    arrayList.Remove(removeItem.ToLower());

            //    Console.WriteLine("Item is deleted");
            //    Console.WriteLine("New list of items \n");
            //    foreach (string a in arrayList)
            //    {

            //        Console.WriteLine(a);
            //    }

               
                //array list add elements
                ArrayList fruits = new ArrayList();
                fruits.Add("apple");
                fruits.Add("banana");
                fruits.Add("cherry");
                fruits.Add("date");
                fruits.Add("elderberry");

            Console.WriteLine("Number of elements in the list:" + fruits.Count);

            Console.WriteLine("Fruits in the list");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine("Enter item you want to search");
            string searchFruit = Console.ReadLine();


            int index = fruits.IndexOf(searchFruit);
            if (index == -1)
            {
                Console.WriteLine("Not found!!!!");


            }
            else
            {
                Console.WriteLine("Item is exist in the list");

            }


            Console.WriteLine("Enter fruit you want to add in the list");
            string addFruit = Console.ReadLine();
            fruits.Insert(1, addFruit);
            Console.WriteLine("List after adding fruit:");
            foreach (var fruit in fruits) { Console.WriteLine(fruit); }


            Console.WriteLine("Enter item you want to delete");
            string removeItem = Console.ReadLine();
            int index1 = fruits.IndexOf(removeItem);
            
            if(index1 == -1)
            {
                Console.WriteLine("No such item is in the list");
            }
            else
            {
                fruits.Remove(removeItem);
                Console.WriteLine("List of fruits after removing:");
                foreach (var a in fruits) { Console.WriteLine(a); }
            }
            


            Console.ReadKey();
            }


        }
    }


