using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee_having_field_and_method
{
    class Employee
    {
        int employeeN;
        string name;
        int Salary;
        string Address;
        long mobilenum;
        string email;

        public  void getdata()
        {
            Console.WriteLine("Enter Employee no:");
            employeeN = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary :");
            Salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Address :");
            Address = Console.ReadLine();
            Console.WriteLine("Enter the mobile number :");
            mobilenum = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the Email-Id");
            email = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("EMployee Name =" + name);
            Console.WriteLine("Employee number =" + employeeN);
            Console.WriteLine("Employee Salary =" + Salary);
            Console.WriteLine("Employee Address =" + Address);
            Console.WriteLine("Employee Mobile Number =" + mobilenum);
            Console.WriteLine("Employee Email-id =" + email);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.getdata();
            e1.Display();
            Employee e2 = new Employee();
            e2.getdata();
            e2.Display();

        }
    }
}
