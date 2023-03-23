using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_WITH_PARAMETER_returnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            int result = Calculate_Square(number);
            Console.WriteLine("Square= " + result);
            Console.ReadKey();
        }
        static int Calculate_Square(int num)
        {
            int Square = num * num;
            return Square;
        }
    }
}
