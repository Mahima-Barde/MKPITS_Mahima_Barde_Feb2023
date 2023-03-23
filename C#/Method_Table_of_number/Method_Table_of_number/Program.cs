using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Table_of_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int t;
            Console.WriteLine("Enter the number");
            t = Convert.ToInt32(Console.ReadLine());

            //Calling a method Table to display table of given
            //number

            table(t);
            Console.ReadKey();
        }

        static void table(int num)
        {
            for(int number=1;number<11;number++)
            {
                int mul = num * number;
                Console.WriteLine(num + " * " + number + " = " + mul);
                Console.WriteLine();
            }

        }
    }
}
