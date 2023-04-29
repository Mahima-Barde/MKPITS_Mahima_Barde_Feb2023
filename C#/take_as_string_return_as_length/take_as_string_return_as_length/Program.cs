using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace take_as_string_return_as_length
{
    internal class Program
    {//Write a C# method that takes a string as a parameter and returns its length.
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string");
            str = Console.ReadLine();
            int length;
            length = calculate_length(str);
            Console.WriteLine("Length =" + length);
            Console.ReadKey();
        }
        static int calculate_length(string l)
        {
            int a = l.Length;
            return a;
        }
    }
}
