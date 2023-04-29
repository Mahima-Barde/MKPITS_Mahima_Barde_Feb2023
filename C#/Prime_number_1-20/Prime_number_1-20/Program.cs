using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_number_1_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            for (int outerloop = 1; outerloop <= 20; outerloop++)
            {
                int isprime = 0;
                int number = outerloop;
                for(int Counter=2;Counter<number;Counter++)
                {
                    if(number%Counter==0)
                    {
                        isprime = 1;
                        break;
                    }
                }
           
                if(isprime==0)
                {
                    Console.WriteLine(number + "is a prime number");
                } 
            }
            Console.ReadKey();
        }
    }
}
