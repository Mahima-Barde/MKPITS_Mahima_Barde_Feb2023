using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Call_from_another_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            display();
            Console.ReadKey();
        }  
            static void display()
            {
            int num1 = 4;
            int num2=7,result;
            int add=addition(num1,num2);
            Console.WriteLine(add);
            int sub=Subtraction(num1,num2);
            Console.WriteLine(sub);
            }
        static int addition(int n1,int n2)
        {
            int res = n1 + n2;
            return res;
        }
        static int Subtraction(int n1, int n2)
        {
            int res = n1-n2;
            return res;
        }
    }
}
