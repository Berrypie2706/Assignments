using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17
{
    public class Shape
    {
        string ShapeType;
        double area;
        double perimeter;

      
        public string shapeType { get { return ShapeType; } set { ShapeType = value; } }

        public virtual double Area { get { return area; } }
        public virtual double Perimeter { get { return perimeter; } }
    }
}
