﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_by_out_parameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float area ,circumference;
            int radius;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            CalculateArea(radius, out area, out circumference);
            Console.WriteLine("area=" + area);
            Console.WriteLine("Circumference =" + circumference);
            Console.ReadKey();
        }
        static void CalculateArea(int r, out float a, out float c)
        {
            a = 3.14f * r * r;
            c = 2 * 3.14f * r;
        
        }


    }
}
