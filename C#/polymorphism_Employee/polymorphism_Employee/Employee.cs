using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_Employee
{
    internal class Employee
    {
        public virtual int CalculateSalary(int sal)
        {
            return 0;
        }
    }
    class Manager : Employee
    {
        int bonus = 5000;
        public override int CalculateSalary(int sal)
        {
            sal = bonus + sal;
            return sal;
        }
    }
    class Engineer : Employee
    {
        int bonus = 3000;
        public override int CalculateSalary(int sal)
        {
            sal = bonus + sal;
            return sal;
        }
    }
    class Salesperson: Employee
    {
        int bonus = 1000;
        public override int CalculateSalary(int sal)
        {
            sal = bonus + sal;
            return sal;
        }
    }
}
