using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rank_length_2_dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 2 }, { 3, 5 }};
            for(int row=0;row<2;row++)
            {
                for(int column=0;column<2;column++)
                {
                    Console.Write(array[row, column]+"\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Ranke = " + array.Rank);
            Console.WriteLine("Length =" + array.Length);
            Console.ReadKey();
        }

        
    }
}
