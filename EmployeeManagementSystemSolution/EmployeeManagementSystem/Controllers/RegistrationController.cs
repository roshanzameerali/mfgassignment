using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EmployeeManagementSystem.Models;
using System.Web.Http.Cors;
using System.Security.Cryptography;
using System.Text;

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
            Employee.Password = Encrypt(Employee.Password);
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

        public string Encrypt(string plainText)
        {
            if (plainText == null) throw new ArgumentNullException("plainText");

            //encrypt data
            var data = Encoding.Unicode.GetBytes(plainText);
            byte[] encrypted = new byte[plainText.Length];
            encrypted = Encoding.UTF8.GetBytes(plainText);

            //return as base64 string
            return Convert.ToBase64String(encrypted);
        }

    }
}
