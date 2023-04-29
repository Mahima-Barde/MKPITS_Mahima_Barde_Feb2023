using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace yyyy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total;
           
            total=Calculate(33, 67, 4, 23, 90);
            Console.WriteLine("total=" + total);
            Console.ReadKey();
            
        }
        static int Calculate(params int[] values)
        {
            int total = 0,T;
            for (int Counter = 0; Counter < values.Length; Counter++)
            {
                total = total + values[Counter];
                
            }
            return total;
        }
    }
}
