using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            float area, circumference;
            Console.WriteLine("Enter the radius");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            Console.WriteLine("Area =" + area);
            circumference = 2 * 3.14f * radius;
            Console.WriteLine("Circumference =" + circumference);
            Console.ReadKey();


        }
    }
}
