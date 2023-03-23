using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_3_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            char op;
            Console.WriteLine("Enter the number1 = ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2 = ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator = '+'/'-'/'*'/'/'");
            op = Convert.ToChar(Console.ReadLine());
            DisplayOperation( n1, n2,op);
            Console.ReadKey();
        }
        static void DisplayOperation(int num1,int num2,char oper)
        {
           if(oper=='+')
            {
                int add = num1 + num2;
                Console.WriteLine("Addition ="+add);
            }
           else if(oper=='-')
            {
                int sub = num1 - num2;
                Console.WriteLine("Subtraction =" + sub);
            }
            else if (oper == '*')
            {
                int mul= num1 * num2;
                Console.WriteLine("Multiplication =" + mul);
            }
            else
            {

                int div = num1 / num2;
                Console.WriteLine("Division =" + div);
            }
        }
    }
}
