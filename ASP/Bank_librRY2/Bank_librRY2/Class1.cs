using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_librRY2
{
    public class Class1
    {

    
    int balance = 1000;
    public string Deposite(int amount)
    {
        int total = amount + balance;
        return "The Deposite is " + total.ToString();
    }

    public string withdral(int amount)
    {
        int total = balance - amount;
        return "The balance is " + total.ToString();

    }




}
}
