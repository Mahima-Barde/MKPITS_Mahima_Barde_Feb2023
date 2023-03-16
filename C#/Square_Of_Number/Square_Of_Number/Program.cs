using System;

namespace SquareOfNumber
{
    class program
    {
        static void Main()
        {
            int num, square;
            Console.WriteLine("Please enter number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square of a number is "+square);
            Console.ReadKey();

        }
    }
}
