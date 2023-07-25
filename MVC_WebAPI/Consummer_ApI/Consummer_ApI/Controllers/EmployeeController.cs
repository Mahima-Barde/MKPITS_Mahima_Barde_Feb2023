using System;
using Consummer_ApI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Consummer_ApI.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        //How can we use API in our application
        string baseurl = "http://localhost:50253/api/employee";
        public async Task<ActionResult> Index()
        {
            List<Employee> Empinfo = new List<Employee>();
            using (var client = new HttpClient())
            { 
            //passing services base url
            client.BaseAddress=new Uri(baseurl);

                client.DefaultRequestHeaders.Clear();

                //Define request data format
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //sending request to find web api REST services resources GetAllEmployee using Http client
               
                HttpResponseMessage res=await client.GetAsync(baseurl);

                //checking the response details received from web appi
                 if(res.IsSuccessStatusCode)
                {
                    //storing the response details received from web api
                    var EmpResponse = res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response received from web api and storing into the Employ

                    Empinfo = JsonConvert.DeserializeObject<List<Employee>>(EmpResponse);
                }

                 //returning the employee list to view
            }
            return View(Empinfo);
        }
    }
}