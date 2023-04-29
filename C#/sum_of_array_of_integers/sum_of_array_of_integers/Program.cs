using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_array_of_integers
{
    internal class Program
    {
   // C# method that takes an array of integers as a parameter and returns the sum of all the integers in the array.
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 4, 7, 2 };
            Add(arr);
            Console.ReadKey();

        }
        static void Add(int[] add)
        {
            int sum = 0;
            foreach (int val in add)
            {
                 sum = sum + val;
            }
            Console.WriteLine("The sum of integers is =" + sum);
        }

    }
}
