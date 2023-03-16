using System;
   
namespace AreaofRectangle
{
    class Programe
    {
        static void Main()
        {
            int length, breadth, area;
            Console.WriteLine("Enter the Length :");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breadth:");
            breadth = Convert.ToInt32(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("Area=" + area);


        }

    }
}