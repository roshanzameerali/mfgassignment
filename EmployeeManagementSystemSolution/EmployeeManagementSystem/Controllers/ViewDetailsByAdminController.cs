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

    [RoutePrefix("GetDepartmentAndBusinessDetails")]
    public class ViewDetailsByAdminController : ApiController
    {
        [Route("GetDepartmentDetails")]
        [HttpGet]
        public HttpResponseMessage GetDepartmentDetails()
        {
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();
            var result = entities.proc_GetAllDepartments();
            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No Employees are there");
            else
                return Request.CreateResponse(result);
        }


        [Route("GetBusinessUnitDetails")]
        [HttpGet]
        public HttpResponseMessage GetBusinessUnitDetails()
        {
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();
            var result = entities.proc_GetAllBusinessUnits();
            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "No Employees are there");
            else
                return Request.CreateResponse(result);
        }

    }
}
