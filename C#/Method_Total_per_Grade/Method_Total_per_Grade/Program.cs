using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Total_per_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Subject1 =");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject2 =");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject3 =");
            int s3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject4 =");
            int s4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Subject5 =");
            int s5 = Convert.ToInt32(Console.ReadLine());
            int Total = Method_Total(s1, s2, s3, s4, s5);
            Console.WriteLine("Total =" + Total);
            int per =Convert.ToInt32(Method_percentage(Total));
            Console.WriteLine("per =" + per);
            string grade = Method_grade(per);
            Console.WriteLine("grade =" + grade);
            Console.ReadKey();
        }
        static int Method_Total(int sub1, int sub2, int sub3, int sub4, int sub5)
        {
            int t = sub1 + sub2 + sub3 + sub4 + sub5;
            return t;
        }
        static float Method_percentage(int p)
        {
            float per = (p / 500.0f)* 100.0f;
            return per;

        }
        static string Method_grade(int g)
        {
            if (g >= 75)
            {
                string grade = "A_grade";
                return grade;
            }
            else if (g >= 50 && g < 75)
            {
                string grade = "B_grade";
                return grade;
            }
            else if (g > 35 && g < 50)
            {
                string grade = "C_grade";
                return grade;
            }
            else
            {
                string grade = "Fail";
                return grade;
            }

        }

    }
}