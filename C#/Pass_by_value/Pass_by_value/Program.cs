using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pass_by_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine("Number outside is = " + num);
            Display(num);
            Console.WriteLine("Number outside is = " + num);
            Console.ReadKey();
        }
        static void Display(int num)
        {
            num = num + 5;
            Console.WriteLine("Number inside display" + num);
        }
        

        
    }
}
