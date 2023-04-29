using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runtime_polymorphism
{
    class Account
    {
       public  int bal = 500;
        public  virtual void deposite(int amt)
        {
            Console.WriteLine("deposite method of account class ");
        }
    }
        class Saving : Account
        {
            int interest = 500;
        
            public override void deposite(int amt)
            {
                bal = bal + interest + amt;
                Console.WriteLine("Deposite balance with interest=" + bal);
            }
        }
    class current:Account
    {
        public override void deposite(int amt)
        {
            bal = bal + amt;
            Console.WriteLine("Current without interest=" + bal);
        }

    }
        internal class Program
        {
            static void Main(string[] args)
            {
            Account act = null;
            int amount;
            string acttype;
            Console.WriteLine("Enter the amount");
            amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the account type=");
            acttype = Console.ReadLine();
            if (acttype == "current")
            {
                 act = new current();

            }

            else if(acttype=="saving")
            {

                 act = new Saving();
            }
                act.deposite(200);
                Console.ReadKey();
            }
        }
 }


