using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_CLear_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 7, 12, 6, 3, 9 };
            Array.Clear(arr, 3, 1);
            for(int length=0;length<arr.Length;length++)
            {
                Console.WriteLine(arr[length]);
            }
            Console.ReadKey();

        }
    }
}
