using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Clone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 3, 6, 12, 8, 9 };
            int[] num1 = (int[])num.Clone();
            for(int i=0;i<num.Length;i++)
            {
                Console.WriteLine(num1[i]);
            }
            Console.ReadKey();


        }
    }
}
