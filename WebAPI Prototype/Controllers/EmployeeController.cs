using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


using WebAPI_Prototype.Models;    //This retrieve the model from the models. It is the main model first one to be seen



namespace WebAPI_Prototype.Controllers
{
    public class EmployeeController : ApiController
    {

        IList<Employee> employees = new List<Employee>()
        {
            new Employee()
                {
                    EmployeeId = 1, EmployeeName = "Juan De Cruz", Address = "Manila", Department = "IT"
                },
                new Employee()
                {
                    EmployeeId = 2, EmployeeName = "Dorothy Ember", Address = "Mexico", Department = "Account"
                },
                new Employee()
                {
                    EmployeeId = 3, EmployeeName = "Messi Rue", Address = "Spain", Department = "Engineering"
                },
                new Employee()
                {
                    EmployeeId = 4, EmployeeName = "Adol Cristin", Address = "Ireland", Department = "Logistics"
                },
                new Employee()
                {
                    EmployeeId = 5, EmployeeName = "Rean Schwarzer", Address = "Berlin", Department = "HR"
                },
        };
        public IList<Employee> GetAllEmployees()
        {
            //Return list of all employees  
            return employees;
        }
        public Employee GetEmployeeDetails(int id)
        {
            //Return a single employee detail  
            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);
            if (employee == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return employee;
        }




















    }
}
