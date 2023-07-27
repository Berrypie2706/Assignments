using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
   public class Rectangle : Shape
    {
        double width;
        double height;
        
  

        public double Width { get { return width; } set {  width = value; } }   
            
        public double Height { get { return height; } set {  height = value; } }



        public Rectangle(double width, double height)
        {
            shapeType = "Rectangle";
            this.width = width;
            this.height = height;
        }
        public override double Area => Width * Height;

        public override double Perimeter => 2 * (Width + Height);

        public void PrintInfo()
        {
            Console.WriteLine($"ShapeType: {shapeType} \nArea: {Area} \nPerimeter: {Perimeter}");
        }
    }
}
