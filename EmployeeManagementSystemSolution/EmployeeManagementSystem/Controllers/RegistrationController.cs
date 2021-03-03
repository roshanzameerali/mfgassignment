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
    public class RegistrationController : ApiController
    {
        dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();
        public IEnumerable<tblEmployee> Get()
        {
            return entities.tblEmployees.ToList();
        }
        [HttpPost]
        public HttpResponseMessage RegisterEmployee(tblEmployee Employee)
        {
            string result = null;
            result = entities.proc_CheckAlreadyExistingEmployee(Employee.mobile_number).FirstOrDefault();
            if(result == null)
            {
                entities.tblEmployees.Add(Employee);
                entities.SaveChanges();
            }
            else
            {
                return Request.CreateResponse("Employee already exists");
            }
            var Employee_Id = entities.proc_GenerateEmployee_id(Employee.Employee_id);
            return Request.CreateResponse(Employee_Id);
        }

    }
}
