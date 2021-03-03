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
                entities.SaveChanges();
            }

            [Route("EditUnitName")]
            [HttpPut]
            public void UnitNamePut(int id, tblEmployee Employee)
            {
                tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
                UpdateEmployee.Unit_id = Employee.Unit_id;
                entities.SaveChanges();
            }

            [Route("EditDepartment")]
            [HttpPut]
            public void DepartmentPut(int id, tblEmployee Employee)
            {
                tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
                UpdateEmployee.Department_id = Employee.Department_id;
                entities.SaveChanges();
            }

        
    }
}