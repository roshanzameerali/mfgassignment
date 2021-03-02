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


    public class UpdateByEmployeeController : ApiController
    {    
        
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();

            public void Put(int id, tblEmployee Employee)
            {
                tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
                UpdateEmployee.Email_id = Employee.Email_id;
                UpdateEmployee.mobile_number = Employee.mobile_number;
                UpdateEmployee.Address = Employee.Address;
                UpdateEmployee.City = Employee.City;
                UpdateEmployee.State = Employee.State;
                UpdateEmployee.Pincode = Employee.Pincode;
                entities.SaveChanges();
            }

            //[Route("EditMobileNumber")]
            //[HttpPut]
            //public void MobileNumberPut(int id, tblEmployee Employee)
            //{
            //    tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
            //    UpdateEmployee.mobile_number = Employee.mobile_number;
            //    entities.SaveChanges();
            //}

            //[Route("EditAddress")]
            //[HttpPut]
            //public void AddressPut(int id, tblEmployee Employee)
            //{
            //    tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
            //    UpdateEmployee.Address = Employee.Address;
            //    entities.SaveChanges();
            //}

            //[Route("EditCity")]
            //[HttpPut]
            //public void CityPut(int id, tblEmployee Employee)
            //{
            //    tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
            //    UpdateEmployee.City = Employee.City;
            //    entities.SaveChanges();
            //}


            //[Route("EditState")]
            //[HttpPut]
            //public void StatePut(int id, tblEmployee Employee)
            //{
            //    tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
            //    UpdateEmployee.State = Employee.State;
            //    entities.SaveChanges();
            //}


            //[Route("EditPincode")]
            //[HttpPut]
            //public void PincodePut(int id, tblEmployee Employee)
            //{
            //    tblEmployee UpdateEmployee = entities.tblEmployees.Find(id);
            //    UpdateEmployee.Pincode = Employee.Pincode;
            //    entities.SaveChanges();
            //}
        
    }
}
