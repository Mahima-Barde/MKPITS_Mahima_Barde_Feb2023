using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_oops_without_parameter
{
    class student
    {
        int rollnum;
        string name;
        public student()
        {
            rollnum = 117;
            name = "Mahima";
        }

        public void display()
        {
            Console.WriteLine("Roll Number= " + rollnum);
            Console.WriteLine("Name =" + name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stud1 = new student();
            stud1.display();
            Console.ReadKey();
        }
    }
}
