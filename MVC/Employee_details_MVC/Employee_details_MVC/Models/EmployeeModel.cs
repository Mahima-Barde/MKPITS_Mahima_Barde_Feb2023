using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee_details_MVC.Models
{
    public class EmployeeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int price{ get; set; }
        public string Department { get; set; }
        public int age { get; set; }

    }
}