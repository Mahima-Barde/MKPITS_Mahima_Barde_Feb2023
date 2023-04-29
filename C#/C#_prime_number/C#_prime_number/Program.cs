using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int counter = 2; counter < number; counter++)
            {
                int isprime = 0;
                if (number % counter == 0)
                {
                    isprime = 1;
                    break;
                  
                }
                else
                {
                    Console.WriteLine("It is Prime Number ");
                }
            
                
                Console.ReadKey();

            }
        }
    }
}
