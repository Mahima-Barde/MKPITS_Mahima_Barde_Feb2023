using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Non_repating_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string input = "shakuntshla";
            char[] arr = input.ToCharArray();
            int index;
            char res = Non_repeting_character(input);
            for(int i=0;i<input.Length;i++)
            {
                if (arr[i] == res)
                {
                    Console.WriteLine("the index of character is notrepeting is {0}", i);
                }
            }
            if(res!='\0')
            {
                Console.WriteLine("The non-repeting character is {0}", res);
            }
            else
            {
                Console.WriteLine("The non-repating character is {0}",res);

            }
        }
        static char Non_repeting_character( string input)
        {
            char result = '\0';
            for (int count=0;count<input.Length;count++)
            {
                bool isrepeted = false;
                for (int innercount = 0; innercount < input.Length; innercount++)
                {
                    if (count != innercount && input[count] == input[innercount]) ;
                    {
                        isrepeted = true;
                        break;
                    }
                   
                    
                }
                
                if(isrepeted==false)
                {
                     result = input[count];
                    int i = count;
                    
                }

                
            }
            return result;

        }
    }
}
