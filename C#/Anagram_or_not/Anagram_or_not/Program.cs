using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram_or_not
{
    internal class Program
    {
        //Write a C# method that takes two strings as parameters and
        //returns true if they are anagrams, false otherwise.
        static void Main(string[] args)
        {
            string str1 = "Silent";
            string str2 = "Listen";
            bool b = Anagram(str1, str2);
            Console.WriteLine(b);
            Console.ReadKey();
        
        }
        static bool Anagram(string a, string b)
        {
            char[] ch1 = a.ToLower().ToCharArray();
            char[] ch2 = b.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("String is Anagram");
                return true;


            }
            else
            {
                Console.WriteLine("String is  not Anagram");
                return  false;
            }

            

        }   
     }
}
