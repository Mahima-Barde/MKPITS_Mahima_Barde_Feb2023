using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enter_a_Byte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b;
            Console.WriteLine("Enter the number :");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Number is " + b);
            Console.ReadKey();

        }
    }
}
