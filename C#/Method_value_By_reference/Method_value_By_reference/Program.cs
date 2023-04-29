using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_value_By_reference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circumference;
            area = 0.0f;
            circumference = 0.0f;
            Console.WriteLine("Enter the radius");
            radius = Convert.ToInt32(Console.ReadLine());
            Calculate_area(radius, ref area, ref circumference);
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Circumference " + circumference); 
            Console.ReadKey(); 
        }
        static void Calculate_area(int r,ref float a,ref float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        }
    }
}
