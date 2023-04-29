using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Statement_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] name = { "Mahima", "Shreya", "Rupali", "Monali" };
            int[] number = { 1, 2, 3, 4, 12 };
         
            foreach(string val in name)
            {
                Console.WriteLine("Name = " + val);
            }
            foreach (int val in number)
            {
                
                Console.WriteLine(("number= " + val));
            }
            Console.ReadKey();
        }
    }
}
