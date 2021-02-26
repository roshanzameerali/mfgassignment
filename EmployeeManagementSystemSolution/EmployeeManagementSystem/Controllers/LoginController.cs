using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeManagementSystem.Models;
using System.Web.Http.Cors;

namespace EmployeeManagementSystem.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Login(tblEmployee Employee)
        {
            int id = Employee.Employee_id;
            string password = Employee.Password;
            
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();
            var result = entities.proc_EmployeeLogin(id,password);
            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Login");
            else
                return Request.CreateResponse(result);
        }


    }
}
