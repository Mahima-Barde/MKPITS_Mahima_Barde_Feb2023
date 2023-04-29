using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace bank_account_runtime_polymorphism
{
  
     internal class Account
    {
        string actype;
        //int amount;
        public int bal = 1000;
        Account act = null;
        public virtual int deposit(int amt)
        {
            return 0;
        }
    }
     class Saving:Account
    {
        int interest = 500;
        public override int deposit(int amt)
        {
            bal = bal + interest + amt;
            return bal;
        }
    }
    class current:Account
    {
        public override int deposit(int amt)
        {
            bal = bal + amt;
            return  bal;
        }
    }

}
