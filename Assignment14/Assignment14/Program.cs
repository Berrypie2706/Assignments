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
                for (int j = 0; j < n - 1-1 ; j++)
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
        static bool IsArraySorted(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
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
            int[] sortedArray2 = (int[])randomArray.Clone();

            Console.WriteLine("Random Array:");            
            Print(sortedArray1);
            //Bubble sorting
            Stopwatch sw = new Stopwatch();
            sw.Start();
            BubleSort(sortedArray1);
            sw.Stop();
            Console.WriteLine("After Bubble sort");        
            Print(sortedArray1);
            Console.WriteLine("Is sortedArray sorted after applying bubble sort? " + IsArraySorted(sortedArray1));
            Console.WriteLine($"ArraySize {sortedArray1.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");

            Console.WriteLine("________________________________________________________________________________________________-");

            //Insertion sorting
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            Insertion(sortedArray2);
            sw1.Stop();
            
            Insertion(sortedArray2);
            Console.WriteLine("After Insertion sort");
            Print(sortedArray2);
            
            Console.WriteLine("Is sortedArray sorted after applying insertion sort? " + IsArraySorted(sortedArray2));
            Console.WriteLine($"ArraySize {sortedArray2.Length} Time Taken {sw1.Elapsed.TotalMilliseconds} milliseconds");

            Console.ReadKey();



                
            }
        }
    }



