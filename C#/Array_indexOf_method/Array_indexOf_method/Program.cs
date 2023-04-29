using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_indexOf_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 67, 2, 7, 34, 0, 8, 1 };
            int l = Array.IndexOf(arr, 0);
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
