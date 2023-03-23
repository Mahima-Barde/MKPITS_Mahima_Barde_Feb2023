using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accept_the_character_dispaly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char character;
            Console.WriteLine("Enter the Character");
            character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Character is " + character);
            Console.ReadKey();

        }
    }
}
