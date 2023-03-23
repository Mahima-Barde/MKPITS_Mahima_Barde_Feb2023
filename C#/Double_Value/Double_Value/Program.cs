using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d;
            Console.WriteLine("Enter the Double value ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your number is " + d);
            Console.ReadLine();

        }
    }
}
