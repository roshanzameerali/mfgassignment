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
    public class LoginController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage Login(tblEmployee Employee)
        {
            int id = Employee.Employee_id;
            string password = Encrypt(Employee.Password);
            
            dbEmployeesSystemEntities1 entities = new dbEmployeesSystemEntities1();
            var result = entities.proc_EmployeeLogin(id,password);
            if (result == null)
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Invalid Login");
            else
                return Request.CreateResponse(result);
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
