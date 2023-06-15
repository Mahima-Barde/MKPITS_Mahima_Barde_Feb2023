using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        //create a function with parameter and return value
        public string Addition(int number1,int number2)
        {
            int result=number1+number2;
            return "addition is " + result.ToString();
;
        }
        public string Subtraction(int number1, int number2)
        {
            int result = number1-number2;
            return "subtraction is " + result.ToString();
            ;
        }
        public string Multiplication(int number1, int number2)
        {
            int result = number1 * number2;
            return "Multiplication is " + result.ToString();
            ;
        }

        public string Division(int number1, int number2)
        {
            double result = number1/ number2;
            return "Division is " + result.ToString();
            ;
        }



    }
}
