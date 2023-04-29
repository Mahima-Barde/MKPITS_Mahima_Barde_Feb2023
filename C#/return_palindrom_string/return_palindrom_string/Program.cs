using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_palindrom_string
{
    internal class Program
    {
        //Write a C# method that takes a string as a parameter and returns true
        //if the string is a palindrome, false otherwise.
        static void Main(string[] args)
        {
            string str = "stray";
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string q=Console.ReadLine(new string(charArray));
            ifPalindrom(q,str);
            Console.ReadKey();
        }
        static void ifPalindrom(string a,string firststr)
        {
            if(a==firststr)
            {
                Console.WriteLine("String is Palindrom");
            }
            else
            {
                Console.WriteLine("String is not Palindrom");
            }
        }
    }
}
