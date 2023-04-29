using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class_customer
{
    class Order
    {
        public void Display(int O, string nm, int q, long t)
        {

            Console.WriteLine("Order no.:" + O);
            Console.WriteLine("Order name:" + nm);
            Console.WriteLine("Order Quantity:" + q);
            Console.WriteLine("Order total:" + t);

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int orderno;
            string ordername;
            int quantity;
            long total;
            Order o1 = new Order();
            Console.WriteLine("Enter Order no:");
            orderno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Order name:");
            ordername = Console.ReadLine();
            Console.WriteLine("Enter the Quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter total:");
            total =Convert.ToInt32(Console.ReadLine());
            o1.Display(orderno, ordername, quantity, total);
            Console.ReadKey();

        }
    }
}
