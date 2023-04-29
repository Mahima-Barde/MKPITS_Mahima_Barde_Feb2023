using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //    1
         //   121
         //  12312
         // 1234123
         //123451234

            for(int row=1;row<=5;row++)
            {
                for (int column =(7-row); column>=(5-row); column--)
                {
                    Console.Write(row+" ");
   
                }

                Console.WriteLine(" ");
            }
            Console.ReadKey();

        }
    }
}
