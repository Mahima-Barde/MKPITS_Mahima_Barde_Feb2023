using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Multiplication_of_2D_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[3,3];
            int[,] array2 = new int[3,3];
            int[,] array3 = new int[3,3];
            array1 = Taking_array(array1);
            transpose(array1);
            Console.ReadKey();
               
        }
        static int[,] Taking_array(int[,] a1)
        {
            for(int row=0;row<3;row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write("Enter the number");
                    a1[row,column] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(a1[row, column]+"\t");
                    
                }
                Console.WriteLine("\n");
            }
            return a1;
        }
        static void transpose(int[,] arr1)
        {
            int[,] array2 = new int[3, 3];
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    array2[row,column] = arr1[column,row];
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(array2[row, column]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
