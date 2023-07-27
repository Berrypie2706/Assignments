using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Circle:Shape
    {
        
        double radius;
      
        public double Radius { get; set; }
        public Circle(double radius)
        {
            shapeType = "Circle";
            this.radius = radius;
        }

        public override double Area=>(Math.PI* radius * radius);
        public override double Perimeter=>2 * Math.PI * radius;

        public void PrintInfo()
        {
            Console.WriteLine($"ShapeType:\t {shapeType} \nArea:\t {Area} \nPerimeter:\t {Perimeter}");
        }



    }




}
