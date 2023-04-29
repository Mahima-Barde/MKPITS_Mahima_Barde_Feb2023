using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Addition_of_array_in_2D
{
    internal class Program
    {
        //create 2 arrays of 3rows and 3 colums and
        //then create a third array to store addition of 2 array
        static void Main(string[] args)
        {
            int[,] array1 = new int[3, 3];
            int[,] array2 = new int[3, 3];
            int[,] array3 = new int[3, 3];
            array1 = Element_array1(array1);
            array2 = Element_array1(array2);
            Addition_2Array(array1, array2);

            Console.ReadKey();

        }
        static int[,] Element_array1(int[,] a1)
        {
            int[,] arra1 = new int[3, 3];
            arra1 = Taking_array(a1);
            return arra1;
        }
        static int[,] Element_array2(int[,] a2)
        {
            int[,] arra1 = new int[3, 3];
            arra1 = Taking_array(a2);
            return arra1;
        }
        static int[,] Taking_array(int[,] arr1)
        {
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.WriteLine("Enter the element for array (" + row + "," + column + ")");
                    arr1[row, column] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    Console.Write(arr1[row, column] + "\t");
                }
                Console.WriteLine();
            }
            return arr1;

        }
        static void Addition_2Array(int[,] a1, int[,] a2)
        {
            int[,] a3 = new int[3, 3];
            for (int row = 0; row<3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    a3[row, column] = a1[row, column] + a2[row, column];
                   
                }
            }
            Console.WriteLine("Addition of array3=");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column <3; column++)
                {
                    Console.Write(a3[row, column]+"\t");

                }
                Console.WriteLine();

            }


        }
    }
}


       
