using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_getLength_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 6, 12, 7, 3, 9 };
            int l = arr.GetLength(0);
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
