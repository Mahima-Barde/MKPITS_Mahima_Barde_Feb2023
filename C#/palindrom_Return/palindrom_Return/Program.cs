using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom_Return
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "stray";
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(new string(charArray));
            string q = Console.ReadLine();
            ifPalindrom(q, str);
            Console.ReadKey();
        }
        static void ifPalindrom(string a, string firststr)
        {
            if (a == firststr)
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
