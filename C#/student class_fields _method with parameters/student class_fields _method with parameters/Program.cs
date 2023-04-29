using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace student_class_fields__method_with_parameters
{

    class StudentInfo
    {
        int rollnum;
        string name;
        public void getdata(int r,string n)
        {
            rollnum = r;
            name = n;

        }
        public void dispaly()
        {
            Console.WriteLine("Name =" + name);
            Console.WriteLine("Roll Number=" + rollnum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentInfo Stud1 = new StudentInfo();
            Stud1.getdata(117, "Mahima");
            Stud1.dispaly();
            Console.ReadKey();
        }
    }
}
