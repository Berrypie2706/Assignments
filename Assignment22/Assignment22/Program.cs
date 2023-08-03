using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    public class Program
    {
        public static void MapProperties(object Source, object Destination)
        {
            Type type = Source.GetType();
            Type type1 = Destination.GetType();

            PropertyInfo[] sourceProperties = type.GetProperties();
            PropertyInfo[] destProperties = type1.GetProperties();

            foreach(PropertyInfo sourceProperty in sourceProperties)
            {
                PropertyInfo destProperty = Array.Find(destProperties,p => p.Name == sourceProperty.Name && p.PropertyType == sourceProperty.PropertyType);
             if(destProperty != null && destProperty.CanWrite)
                {
                    destProperty.SetValue( Destination, sourceProperty.GetValue(Source));
                }
            }
        }
        static void Main(string[] args)
        {
            Source source = new Source()
            {
              //  ID = 1,
                Name = "Test",
                Age = 20
            };
            Destination source2 = new Destination();

            MapProperties(source, source2);

            Console.WriteLine("Mapping successful. Destination properties:");
            Console.WriteLine($"Id: {source2.ID}");
            Console.WriteLine($"Name: {source2.Name1}");
            Console.WriteLine($"Age: {source2.Age}");
            Console.WriteLine($"Salary: {source2.Salary}");
            Console.WriteLine($"Address: {source2.Address}");

            Console.ReadKey();


        }
    }
}
