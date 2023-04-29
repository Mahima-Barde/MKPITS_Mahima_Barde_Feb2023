using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Acount_class
{
    abstract class Account
    {
        public int bal = 1000;
        public abstract void deposit(int amt);
        public int showbalance()
        {
          return bal;
        }
    }
    class Saving:Account
    {
        int interest = 500;
        public override void deposit(int amt)
        {
            bal = bal + interest;
            Console.WriteLine("Balance with interest =" + bal);
        }

    }
    class Current:Account
    {
        public override void deposit(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Balance without interest =" + bal);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int amount;
            string acctype;
            Console.WriteLine("Enter the amount =");
            amount = Convert.ToInt32(Console.ReadLine());
            Account act = null;
            Console.WriteLine("Enter Accounttype Saving or Current =");
            acctype = Console.ReadLine();
            if (acctype == "Saving") 
            {
                act = new Saving();
            }
            else if(acctype=="Current")
            {
                act = new Current();
            }
            act.deposit(amount);
            act.showbalance();
            Console.ReadKey();

        }
    }
}
