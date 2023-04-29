using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructure_with_parameter
{
    class StudetInfo
    {
        int rollnum;
        string name;
        public StudetInfo(string name,int rollnum)
        {
            this.name = name;
            this.rollnum = rollnum;
        }
        public void display()
        {
            Console.WriteLine("The name of Student is =" + name);
            Console.WriteLine("The roll number is =" + rollnum);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the student Name =");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the roll no:");
            int rollnum = Convert.ToInt32(Console.ReadLine());

            StudetInfo stud1 = new StudetInfo(name,rollnum);
            //call a constructor
            stud1.display();
            Console.ReadKey();
        }
    }
}
