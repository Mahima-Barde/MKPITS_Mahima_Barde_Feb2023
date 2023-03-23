using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_with_parameter_no_return_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1= 53;
            int num2 = 78;
            add(num1,num2);
            Console.WriteLine();
        }

        static void add(int n1,int n2)
        {
            int add = n1 + n2;
            Console.WriteLine(add);
        }
    }
}
