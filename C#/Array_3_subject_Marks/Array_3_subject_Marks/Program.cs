using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3_subject_Marks
{
    internal class Program
    {//create a method to accept 3 subject marks and store it in an array
     //and then print total,per and grade
        static void Main(string[] args)
        {
            int sum = 0;
           
            int[] arrSubject=new int[3];
            for (int subject = 0; subject < 3; subject++)
            {
                Console.WriteLine("Enter marks subject" + subject+"=");
                arrSubject[subject] = Convert.ToInt32(Console.ReadLine());
            }
            for (int subject = 0; subject < 3; subject++)
            {
                sum = sum + arrSubject[subject];
            }
            Console.WriteLine("Total=" + sum);
            float per= Calculate_Percentage(sum);
            Console.WriteLine("Percentage=" + per);
            Calculate_grade(per);
            Console.ReadLine();
        }
        static float Calculate_Percentage(int t)
        {
            float p = t / 300f * 100f;
            return p;
        }
        static void  Calculate_grade(float per)
        {
            if(per>75)
            {
                char grade = 'A';
                Console.WriteLine("grade " + grade);
            }
            else if(per<=75 && per>45)
            {
                char grade = 'B';
                Console.WriteLine("grade " + grade);
            }
            else 
            {
                Console.WriteLine("Your are Fail");
            }
        }
    }
}
