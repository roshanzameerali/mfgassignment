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

    [RoutePrefix("EditDetailsByAdmin")]
    public class UpdateByAdminController : ApiController
    {
            
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();

            [Route("EditRole")]
            [HttpPut]
            public void RolePut(int id, tblEmployee Employee)
            {
                tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
                UpdateEmployee.Role = Employee.Role;
                UpdateEmployee.working_under = Employee.working_under;
                UpdateEmployee.Department_id = Employee.Department_id;
                UpdateEmployee.Unit_id = Employee.Unit_id;
                entities.procedure_InsertIntoWorkingUnder(id, Employee.working_under,Employee.First_Name,Employee.Last_Name,Employee.Email_id,Employee.mobile_number);
                entities.SaveChanges();
            }


    }
}
