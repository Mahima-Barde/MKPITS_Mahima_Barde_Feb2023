using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_level_Inheritance
{
    class person
        {
        public string name;
        }
    class student : person
    {
       public int rollnum;
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.rollnum = 117;
            s1.name = "Mahima";
            Console.WriteLine("ROll NUMBER =" + s1.rollnum);
            Console.WriteLine("NAME =" + s1.name);
            Console.ReadKey();
        }
    }
}
