using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herarchical_Inheritance_prog
{
    class account
    {
       public int bal=5000;
       public int accountnum;
        public void deposit(int amt)
        {
            Console.WriteLine("This is a deposit method of account class");
        }
    }
    class saving:account
    {
        int interest = 500;
        //override deposite method of account class
        public void deposit(int amt)
        {
            amt = amt +bal+interest;
            Console.WriteLine("Ammount with interest balance is =" + amt);
        }
    }
    class current:account
    {
        //override deposite method of account class
        public void deposit(int amt)
        {
            amt = bal + amt;
            Console.WriteLine("Amount without interest is="+amt);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            saving s = new saving();
            s.accountnum = 1234;
            s.deposit(1000);
            current c = new current();
            c.accountnum = 456;
            c.deposit(1000);
            Console.ReadKey();
        }
    }
}
