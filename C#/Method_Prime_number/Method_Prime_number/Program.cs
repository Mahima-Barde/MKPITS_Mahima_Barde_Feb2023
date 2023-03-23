using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            Calculate_PrimeNumber(num);
            Console.ReadKey();

        }
        static void Calculate_PrimeNumber(int n1)
        { 
            int i = 2,flag=0;
            while (i < n1)
            {
                if (n1 % i == 0)
                {
                    flag++;
                    break;
                }
            }
                if(flag==0)
                {
                    Console.WriteLine(" It is Prime Number");
                }
                else 
                {
                    Console.WriteLine("It is not Prime Number");
                }
                i++;
        }
    }
}
