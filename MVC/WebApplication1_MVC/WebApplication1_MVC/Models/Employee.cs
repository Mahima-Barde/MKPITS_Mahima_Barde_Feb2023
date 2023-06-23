using System.Collections.Specialized;

namespace WebApplication1_MVC.Models
{
    public class Employee
    {
        string Name;
        int Eid;
        String Address;
        int Salary;
        public Employee(string name,int id,string address,int salary )
        {
            Name = name;
            Eid = id;
            Address = address;  
            Salary = salary;    
        }
        public string employeename
        {
          get
          {
                return Name;
          }
        }
        public int employeeid
        {
            get
            {
                return Eid;
            }
        }
        public  string address
        {
            get
            {
                return Address;
            }
        }
        public int ESalary
        {
            get
            {
                return Salary;
            }
        }
    }
}
