using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_with_parameter_noreturn_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Function Display");
            Display();
            Console.WriteLine("Calling a display method again");
            Display();
            Console.ReadKey();
        }
        static void Display()
        {
            Console.WriteLine("Hello World");
        }
    }
}
