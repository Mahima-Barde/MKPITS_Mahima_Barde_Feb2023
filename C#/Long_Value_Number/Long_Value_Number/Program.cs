using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_Value_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long l;
            Console.WriteLine("Enter the number");
            l = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Number =" + l);
            Console.ReadLine();

        }
    }
}
