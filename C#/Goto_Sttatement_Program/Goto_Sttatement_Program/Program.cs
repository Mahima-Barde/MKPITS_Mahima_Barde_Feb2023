using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goto_Sttatement_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            char oper;
            Console.WriteLine("Enter the num1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operator {'+','-','*','/'}");
            oper = Convert.ToChar(Console.ReadLine());
            if(oper=='+')
            {
                goto add;
            }
            else if(oper=='-')
            {
                goto substraction;
            }
            else if(oper=='*')
            {
                goto multiplication;
            }
            else
            {
                goto Division;
            }
        add:
            
                int result= n1 + n2;
                Console.WriteLine("Addition = " + result);
                goto end;
            
        substraction:
            
                 result= n1 - n2;
                Console.WriteLine("Substraction = " + result);
                goto end;
            
        multiplication:
            
                 result= n1 *n2;
                Console.WriteLine("Multiplication = " + result);
                goto end;
            
        Division:
           
                
                    result = n1 / n2;
                    Console.WriteLine("Division = " + result);
                     goto end;

        end:

            Console.WriteLine("Result:" + result);




            Console.ReadKey();



        }
    }
}
