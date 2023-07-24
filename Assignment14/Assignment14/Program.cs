using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14
{
    internal class Program
    {
        public static void BubleSort(int[] arr)
        {        
            int[] sortedArray = (int[])arr.Clone();
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1 ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        public static void Insertion(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
       
        public static int[] GenerateRandomIntArray(int length, int minValue, int maxValue)
                {
                    if (length <= 0 || minValue > maxValue)
                    {
                        throw new ArgumentException("Invalid input parameters.");
                    }

                    int[] result = new int[length];
                    Random random = new Random();

                    for (int i = 0; i < length; i++)
                    {
                        result[i] = random.Next(minValue, maxValue + 1);
                    }

                    return result;
                }

                public static void Print(int[] arr)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.WriteLine(arr[i] + " ");
                    }
                    Console.WriteLine("\n");
                }
            public static bool IsArraySorted(int[] array,int[] sortedArray)
            {
            sortedArray = (int[])array.Clone();
            if (array == null || array.Length <= 1)
                {
                    return true;
                }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != sortedArray[i])
                {
                    return false;
                }
            }

            return true;
            }        

       
   
           static void Main(string[] args)
        {
                
            int arrayLength = 10;
            int minValue = 100;
            int maxValue = 499;

            int[] randomArray = GenerateRandomIntArray(arrayLength, minValue, maxValue);
            int[] sortedArray1 = (int[])randomArray.Clone();

            Console.WriteLine("Random Array:");            
            Print(randomArray);
            //Bubble sorting
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BubleSort(randomArray);
            sw.Stop();
            Console.WriteLine("After Bubble sort");        
            Print(randomArray);
            Console.WriteLine("Is sortedArray sorted after applying bubble sort? " + IsArraySorted(randomArray, sortedArray1));
            Console.WriteLine($"ArraySize {randomArray.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");

            Console.WriteLine("________________________________________________________________________________________________-");

            //Insertion sorting
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            Insertion(randomArray);
            sw1.Stop();
            
            Insertion(randomArray);
            Console.WriteLine("After Insertion sort");
            Print(randomArray);
            
            Console.WriteLine("Is sortedArray sorted after applying insertion sort? " + IsArraySorted(randomArray, sortedArray1));
            Console.WriteLine($"ArraySize {randomArray.Length} Time Taken {sw1.Elapsed.TotalMilliseconds} milliseconds");

            Console.ReadKey();



                
            }
        }
    }



