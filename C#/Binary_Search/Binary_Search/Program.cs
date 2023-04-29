using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 7, 9, 10, 34, 56, 70 };
            int left = 0;
            int target = 56;
            int right = arr.Length - 1;
            int result = Binary_Search(target, arr, right, left);
            if (result == 0)
            {
                Console.WriteLine("The number {0} is not found", target);
            }
            else
            {
                Console.WriteLine("THe number {0} found", target);
            }
            Console.ReadKey();

        }
        static int Binary_Search(int target, int[] arr, int right, int left)
        {
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] <= target)
                {
                    left = mid + 1;
                }
                else if (arr[mid] == target)
                {
                    return mid;
                }
                else
                {
                    left = mid - 1;
                }
            }
            return 0;
        }
    }
}
            
    
