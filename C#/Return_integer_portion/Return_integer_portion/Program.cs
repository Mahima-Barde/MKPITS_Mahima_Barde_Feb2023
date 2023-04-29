using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_integer_portion
{
    internal class Program
    {
        //Write a C# method that takes a decimal as a parameter
        //and returns the integer portion of the decimal.
        static void Main(string[] args)
        {
            float floatingvalue;
            Console.WriteLine("Enter floating value");
            floatingvalue = float.Parse(Console.ReadLine());
            Return_Intergerportion(floatingvalue);
            Console.ReadKey();
        }
        static void Return_Intergerportion(float f)
        {
            double a=Math.Floor(f);
            Console.WriteLine(a);
        }
    }

}
