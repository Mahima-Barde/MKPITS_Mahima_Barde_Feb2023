using System;

namespace AdditionTwonumber
{
    class Program
    {
        static void Main()
        {
            int num1, num2, add;
            Console.WriteLine("Please enter num1 :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine("Addition of Two number is " + add);
            Console.ReadKey();

        }
    }

}