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
    public class GetPeersController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage GetPeers(tblEmployee Employee)
        {
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();

            int id = Employee.Employee_id;
            int? working_number = Employee.working_under;
            var result = entities.GetPeers(id, working_number);
            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No Employees are there");
            else
                return Request.CreateResponse(result);
        }
    }
}
