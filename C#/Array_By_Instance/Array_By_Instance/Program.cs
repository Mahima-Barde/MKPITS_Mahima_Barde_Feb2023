using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_By_Instance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[4];
            number[0] = 12;
            number[1] = 34;
            number[2] = 90;
            number[3] = 23;
            string[] name = new string[3] {"Mahima","Shreya","Rupali"};
            //Display an array elements
            foreach(int value in number)
            {
                Console.WriteLine("Number is " + value);
                
            }
            foreach (string value in name)
            {
                Console.WriteLine("Name is " + value);

            }
                Console.ReadKey();
        }
    }
}
