using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_student1
{
    class Student
    {
        public int Rollnumber;
        public string Name;
        public string DOB;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Rollnumber = 117;
            student1.Name = "Mahima";
            student1.DOB = "19 / 08 / 2023";
            Console.WriteLine("Name =" + student1.Name);
            Console.WriteLine("Roll.No ="+student1.Rollnumber);
            Console.WriteLine("DOB ="+student1.DOB);
            Console.ReadKey();
        }
    }
}
