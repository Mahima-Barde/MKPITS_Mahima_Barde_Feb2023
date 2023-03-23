using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_with_Parameter_return_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.Write("Enter number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number 2 :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Calling a function Addition");
            result = Addition(num1, num2);
            Console.WriteLine("Addition = " + result);
            Console.WriteLine("\n Calling a function Subtraction");
            result = Substraction(num1, num2);
            Console.WriteLine("Substraction = " + result);
            Console.ReadKey();
        }
        static int Addition(int n1,int n2)
        {
            int add = n1 + n2;
            return add;
        }
    
        static int Substraction(int n1,int n2)
        {
            int sub = n1 - n2;
            return sub;
        }


    }
}
