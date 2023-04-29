using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehicle_Management_hierarchical
{
    class vehicle
    {
        public string companyname="Mahindra";
        public void getdata() 
        {
            Console.WriteLine("getdata of base class will run");
        }

    }
    class tractor:vehicle
    {
        string mileage ="40kmpl";
        long prize = 100000;
        //override getdata()
        public void getdata(string type)
        {
            Console.WriteLine("Company Name =" + companyname);
            Console.WriteLine("Mileage =" + mileage);
            Console.WriteLine("Prize =" + prize);
        }
    }
    class Thar:vehicle
    {
        string EngineDispl="2184 cc";
         string FuelType="Diesel";
        long prize = 900000;
        //override getdata()
        public void getdata(string cn)
        {
            Console.WriteLine("company Name=" + companyname);
            Console.WriteLine("Engine Displ =" + EngineDispl);
            Console.WriteLine("Prize =" + prize);
        }
    }
    class Bulero:vehicle
    {
        int SeatingCapacit = 7;
        string ARAIMileage = "16 Kmpl";
        long prize = 1000000;

        //override getdata()
        public void getdata(string cn)
        {
            Console.WriteLine("company Name=" + companyname);
            Console.WriteLine("Seating Capacity =" + SeatingCapacit);
            Console.WriteLine("Prize =" + prize);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            tractor t = new tractor();
            t.getdata("tractor");
            // Thar th = new Thar();
            // t.getdata("Thar");
            // Bulero b = new Bulero();
            // t.getdata("Bulero");
            Console.ReadKey();

        }
    }
}
