using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show_long_length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 456, 12, 5678, 1, 900, 1111234 };

            for(int counter=0;counter<arr.Length;counter++)
            {
                Console.WriteLine(arr[counter]);
                Array.Sort(arr);
                Console.WriteLine()
                string num = Console.ReadLine();
                int l = num.Length;
                Console.WriteLine(l);
                Console.ReadKey();
            }


        }
    }
}
