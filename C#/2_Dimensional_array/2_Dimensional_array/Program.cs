using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Dimensional_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write("Enter the number"+"\n");
                    arr[row, column] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(arr[row,column]+"\t");
                   
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
