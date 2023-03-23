using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Method_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());
            //Calling a factorial() method
            Factorial(num);
            Console.ReadKey();
        }

        static void Factorial(int number)
        {
            int sum = 1;
            for(int n=1;n<=number;n++)
            {
                sum = sum * n;
            }
            Console.WriteLine("Factorial of a number is " +sum);
        }
    }
}
