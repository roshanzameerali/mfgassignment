﻿using System;
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
    public class DeleteEmployeeController : ApiController
    {
        [HttpDelete]
        public HttpResponseMessage DeleteEmployee(int id)
        {
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();
            var result = entities.proc_deleteEmployee(id);
            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No Employees to delete");
            else
                return Request.CreateResponse(result);
        }

    }
}
