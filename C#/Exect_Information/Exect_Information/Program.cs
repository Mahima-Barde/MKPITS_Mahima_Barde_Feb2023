using System;

namespace ExectInformation
{
    class Program
    {
        static void Main()
        {
            int rn, age;
            double mobilenum;
            string name, course;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Roll.no");
            rn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Mobile number :");
            mobilenum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Course:");
            course = (Console.ReadLine());
            Console.WriteLine("Age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Student info is:");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Roll number: "+rn);
            Console.WriteLine("Course: "+course);
            Console.WriteLine("Mobile: "+mobilenum);
            Console.WriteLine("Age: "+age);

        }
    }
}