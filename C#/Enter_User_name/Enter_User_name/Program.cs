using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_User_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.ReadKey();
        }
    }
}
