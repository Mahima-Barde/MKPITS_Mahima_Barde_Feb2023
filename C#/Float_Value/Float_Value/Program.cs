using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Float_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f;
            Console.WriteLine("Enter Float number :");
            f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Number = " + f);
            Console.ReadKey();
        }
    }
}
