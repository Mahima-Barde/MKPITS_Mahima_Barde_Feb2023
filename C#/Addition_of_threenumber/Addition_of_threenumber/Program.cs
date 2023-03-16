using System;

namespace  AdditionOfthreeNumber
{
    class Programe
    {
        static void Main()
        {
            int num1, num2, num3, add3;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());
            add3 = num1 + num2 + num3;
            Console.WriteLine("Addition of Thhree number is " + add3);
        }
    }
}