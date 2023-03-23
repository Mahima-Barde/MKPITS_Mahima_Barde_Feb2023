using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_without_parameter_reurnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = calculateSquare();
            Console.WriteLine("Sqaure of a number is " + result);
            Console.ReadKey();
        }
        static int calculateSquare()
        {
            int num;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            int Square = num * num;
            return Square;
        }
    }

}
