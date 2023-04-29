using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sort_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 3, 7, 8, 12, 90, 3 };
           
             Array.Sort(arr1);
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine(arr1[i] +"\t");
            }
            Console.Readkey();

        }
    }
}
