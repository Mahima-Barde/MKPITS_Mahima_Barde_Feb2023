using System;
using System.ComponentModel;

namespace parameter_return_sum_two_inter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, sum;
            Console.WriteLine("Enter the number 1:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 2:");
            b = int.Parse(Console.ReadLine());
            Add(a, b);
            Console.ReadKey();
        }
        static void Add(int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum of two number =" + sum);
        }
    }
}
