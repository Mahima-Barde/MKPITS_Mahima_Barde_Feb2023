using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_return_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] funarr = return_array();
            foreach (int i in funarr) 
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        static int[] return_array()
        {
            int[] arr1 = { 4, 8, 12, 9, 34, 0 };
            return arr1;
        }
    }
}
