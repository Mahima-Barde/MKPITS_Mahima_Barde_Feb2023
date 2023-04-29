using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace create_a_class_product
{ 
    class Product
    {
        string company;
        string product;
        int Buildin;
        int warranty;
        string mileage;
        string Color;

        public void Getdata( string Brand, string p,int Bi,int W,string m,string c)
        {
            company = Brand;
            product = p;
            Buildin = Bi;
            warranty = W;
            mileage = m;
            Color = c;
            Console.WriteLine("company Name=" + company);
            Console.WriteLine("product=" + product);
            Console.WriteLine("Build in=" + Buildin);
            Console.WriteLine("Warranty =" + warranty);
            Console.WriteLine("Mileage =" + mileage);
            Console.WriteLine("Car Color=" + Color);
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Product p1 = new Product();
            p1.Getdata("Toyota", "cars",1990,20,"10kmpl","red");
            Console.ReadLine();
        }
    }
}
