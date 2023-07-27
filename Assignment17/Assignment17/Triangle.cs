using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
  public class Triangle:Shape
    {
      public double SideA { get; set; }
      public double SideB { get; set; }
      public double SideC { get; set; }

        public Triangle(double SideA, double SideB, double SideC)
        {
            shapeType = "Triangle";
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
            
        }

        public override double Area
        {
            get
            {
                 double s = (SideA + SideB + SideC) / 2;
                  return Math.Sqrt ( s * (s -  SideA) * (s -SideB) * (s - SideC));
            }

           
        }
        public override double Perimeter => (SideA + SideB + SideC)/2;

       

        public void PrintInfo()
        {
            Console.WriteLine($"ShapeType: {shapeType} \nArea: {Area} \nPerimeter: {Perimeter}" );
        }

    }
}
