using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using System.Xml.Linq;
using API_Webapplication_creation.Models;

namespace API_Webapplication_creation.Controllers
{
    public class EmployeeController : ApiController
    {
        //creating an array of object of employee class
        Employee[] employees = new Employee[]
        {
            new Employee{Id=1, Name ="Mahima",JoingDate=
                DateTime.Parse(DateTime.Today.ToString()),Age=21 },
             new Employee{Id=2, Name ="Shreya",JoingDate=
                DateTime.Parse(DateTime.Today.ToString()),Age=22},
             new Employee{Id=3, Name ="Rupali",JoingDate=
                DateTime.Parse(DateTime.Today.ToString()),Age=23 },

        };
        //creating a method getemployee to return list of employee details
        [HttpGet]
        public IEnumerable<Employee> GetEmployees()
        {
            return employees;//employee is array of object created above
        }
        //creating method getemployee acception id and then returning
        //details of that employee
        public IHttpActionResult GetCustomer(int id)
        {
            var employee = employees.FirstOrDefault((p) => p.Id == id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }
    }
}
