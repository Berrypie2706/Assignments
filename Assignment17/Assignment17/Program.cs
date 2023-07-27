using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius of a circle");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(radius);
            circle.PrintInfo();

            Console.WriteLine("Enter Height and width of a rectangle");
            Console.Write("Height:");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width:");
            double width = Convert.ToDouble(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            rectangle.PrintInfo();

            Console.WriteLine("Enter the sides of a triangle");
            Console.Write("Side A:");
            double sideA = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("Side B:");
            double sideB = Convert.ToDouble(Console.ReadLine());
      
            Console.Write("Side C:");
            double sideC = Convert.ToDouble(Console.ReadLine());
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            triangle.PrintInfo();
        }
    }
}
