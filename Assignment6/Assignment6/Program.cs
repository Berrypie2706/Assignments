using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In this assignment, you will work with jagged arrays in C# to manipulate data.
            //You will perform various operations such as creating jagged arrays, accessing elements, and calculating averages.
            //Create a jagged array called studentScores to store the scores of three students.Each student can have a different number of scores.
            //            Initialize the studentScores array with the following scores:

            //Student 1: 85, 92, 78
            //Student 2: 90, 87, 93, 89
            //Student 3: 76, 88
            //Print the scores of each student using nested loops.

            //Calculate the average score for each student and print the results.

            //Calculate the average score for all the students combined and print the result.

            int[][] studentScores = new int[3][];
            studentScores[0] = new int[3] { 85, 92, 78 };
            studentScores[1] = new int[4] { 90, 87, 93, 89 };
            studentScores[2] = new int[2] { 76, 88 };
            for (int i = 0; i < studentScores.Length; i++)
            {

                Console.Write($"Student{i + 1}\'s score : ");


                for (int j = 0; j < studentScores[i].Length; j++)
                {


                    Console.Write(studentScores[i][j] + ",");


                }
                Console.WriteLine("\n");
            }
                //average score for each student and print results
                    for (int i = 0; i < studentScores.Length; i++)
                    {
                        double sum = 0;

                        for (int j = 0; j < studentScores[i].Length; j++)
                        {
                            sum += studentScores[i][j];
                        }

                        double average = sum / studentScores[i].Length;
                        Console.WriteLine($"Average score for Student {i + 1}: {average}");
                    }

                //average score if all students and print result
                double totalSum = 0;
                int totalScores = 0;

                for (int i = 0; i < studentScores.Length; i++)
                {
                    for (int j = 0; j < studentScores[i].Length; j++)
                    {
                        totalSum += studentScores[i][j];
                        totalScores++;
                    }
                }

                double totalAverage = totalSum / totalScores;
                Console.WriteLine($"Average score for all students combined: {totalAverage}");



            Console.ReadKey();
        }

            
        }

    }

