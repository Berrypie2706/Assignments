using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment15
{

    internal class Program
    {
        //Quick sort method
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }
            Swap(array, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        //Merge sort method

        public static void MergeSort(int[] arr)
        {
            MergeSort(arr, 0, arr.Length -1);
        }

        private static void MergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];
            Array.Copy(arr, left, leftArray, 0, n1);
            Array.Copy(arr, mid + 1, rightArray, 0, n2);
            int i = 0;
            int j = 0;
            int k = left;
            while (i < n1 && j < n2)
            {
                if (leftArray[i] <= rightArray[j])
                {
                    arr[k] = leftArray[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArray[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = rightArray[j];
                j++;
                k++;
            }

        }

        //Print method to print the array
        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine("\n");
        }

        //Method for generating random arrays
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
        //Method to check whether array is sorted or not
        //after performing Quick and Merge Sorting
        //public static bool IsArraySorted(int[] array, int[] sortedArray)
        //{
        //    sortedArray = (int[])array.Clone();
        //    if (array == null || array.Length <= 1)
        //    {
        //        return true;
        //    }

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] != sortedArray[i])
        //        {
        //            return false;
        //        }
        //    }

        //    return true;
        //}

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

            int arrayLength = 60;
            int minValue = 400;
            int maxValue = 5000;

            int[] randomArray = GenerateRandomIntArray(arrayLength, minValue, maxValue);
            int[] sortedArray = (int[])randomArray.Clone();
            int[] sortedArray1 = (int[])randomArray.Clone();

            //int[] sortedArray = { 100, 200, 300, 412, 321, 111, 564, 654, 433 };
            //int[] sortedArray = { 1000, 2000, 3445, 5443, 322, 2112, 1999, 3333 };
            //long[] sortedArray = { 20000,13222, 4555, 67789, 16000, 19078 };
            //long[] sortedArray = { 50000, 40000, 78987, 76899, 88799, 99876};
            Console.WriteLine("Sorting 60 elements in the array");


            Console.WriteLine("Random Array:");
            Print(sortedArray);
            //Quick Sorting

            Stopwatch sw = new Stopwatch();
            sw.Start();
            QuickSort(sortedArray);
            sw.Stop();
            Console.WriteLine("Array after Quick Sorting:");
            Print(sortedArray);
            Console.WriteLine("Is sortedArray sorted after applying bubble sort? " + IsArraySorted(sortedArray));
            Console.WriteLine($"ArraySize {sortedArray.Length} Time Taken {sw.Elapsed.TotalMilliseconds} milliseconds");
            Console.WriteLine("________________________________________________________________________________________________");

            //Merge Sorting


            Stopwatch sw_1 = new Stopwatch();
            sw_1.Start();
            MergeSort(sortedArray1);
            sw_1.Stop();
            Console.WriteLine("Array after Merge Sorting:");
            Print(sortedArray1);
            Console.WriteLine("Is sortedArray sorted after applying bubble sort? " + IsArraySorted(sortedArray1));
            Console.WriteLine($"ArraySize {sortedArray1.Length} Time Taken {sw_1.Elapsed.TotalMilliseconds} milliseconds");
        }
    }
}
