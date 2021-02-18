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
        [HttpPost]
        public void RegisterEmployee(tblEmployee Employee)
        {
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();
            entities.tblEmployees.Add(Employee);
            entities.SaveChanges();
        }

    }
}
