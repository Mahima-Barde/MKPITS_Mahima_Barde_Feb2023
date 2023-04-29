using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_return_square
{
    internal class Program
    {
       // Write a C# method that takes a double as a parameter and returns its square
        static void Main(string[] args)
        {
           double num;
            Console.WriteLine("Enter the number");
            num = Convert.ToDouble(Console.ReadLine());
           double a=Calculate_Square(num);
            Console.WriteLine("Square = " + a);
            Console.ReadKey();
        }
        static double Calculate_Square(double number)
        {
            number = number * number;
            return number;
        }
    }
  
}
