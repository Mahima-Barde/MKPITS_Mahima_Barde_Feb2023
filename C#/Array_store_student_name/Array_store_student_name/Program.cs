using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_store_student_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Name = new string[5];
            for (int name = 0; name < 5; name++)
            {
                Console.WriteLine("Enter the name");
                Name[name] = Console.ReadLine();
            }
            for (int name = 0; name < 5; name++)
            {
                Console.WriteLine("Name of Student " + name + " is " + Name[name]);
            }
            Console.ReadKey();
        }
    }
}
