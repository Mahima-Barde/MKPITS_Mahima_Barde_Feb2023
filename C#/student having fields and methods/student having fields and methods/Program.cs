using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace student_having_fields_and_methods
{
    class Student
    {
        int Rollnumber;
        string Name;

        public void getdata()
        {
            Rollnumber = 117;
            Name = "Mahima";
        }
        public void Display()
        {
            Console.WriteLine("RollNumber=" + Rollnumber);
            Console.WriteLine("Name =" + Name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Stud1 = new Student();
            Stud1.getdata();
            Stud1.Display();
            Console.ReadKey();
        }
    }
}
