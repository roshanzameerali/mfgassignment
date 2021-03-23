﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagementSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbEmployeesSystemEntities1 : DbContext
    {
        public dbEmployeesSystemEntities1()
            : base("name=dbEmployeesSystemEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblBusinessUnit> tblBusinessUnits { get; set; }
        public virtual DbSet<tblDepartment> tblDepartments { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tblWorkingUnder> tblWorkingUnders { get; set; }
    
        public virtual int GetEmployeeDetails(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("GetEmployeeDetails", employeeIdParameter);
        }
    
        public virtual ObjectResult<proc_GetEmployeeDetails_Result> proc_GetEmployeeDetails(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetEmployeeDetails_Result>("proc_GetEmployeeDetails", employeeIdParameter);
        }
    
        public virtual ObjectResult<string> proc_EmployeeLogin(Nullable<int> employee_id, string password)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("proc_EmployeeLogin", employee_idParameter, passwordParameter);
        }
    
        public virtual ObjectResult<storedproc_GetEmployeeDetails_Result> storedproc_GetEmployeeDetails(Nullable<int> employeeId)
        {
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<storedproc_GetEmployeeDetails_Result>("storedproc_GetEmployeeDetails", employeeIdParameter);
        }
    
        public virtual ObjectResult<proc_GetAllEmployees_Result> proc_GetAllEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetAllEmployees_Result>("proc_GetAllEmployees");
        }
    
        public virtual ObjectResult<storedproc_GetAllEmployees_Result> storedproc_GetAllEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<storedproc_GetAllEmployees_Result>("storedproc_GetAllEmployees");
        }
    
        public virtual ObjectResult<procedure_GetAllEmployees_Result> procedure_GetAllEmployees(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procedure_GetAllEmployees_Result>("procedure_GetAllEmployees", employee_idParameter);
        }
    
        public virtual ObjectResult<proc_GetAllEmployees1_Result> proc_GetAllEmployees1(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetAllEmployees1_Result>("proc_GetAllEmployees1", employee_idParameter);
        }
    
        public virtual ObjectResult<GetAllEmployees_Result> GetAllEmployees()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllEmployees_Result>("GetAllEmployees");
        }
    
        public virtual ObjectResult<proc_GetEmployeesForAdmin_Result> proc_GetEmployeesForAdmin()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetEmployeesForAdmin_Result>("proc_GetEmployeesForAdmin");
        }
    
        public virtual ObjectResult<GetDepartmentAndUnitNames_Result> GetDepartmentAndUnitNames(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDepartmentAndUnitNames_Result>("GetDepartmentAndUnitNames", employee_idParameter);
        }
    
        public virtual ObjectResult<string> proc_CheckAlreadyExistingEmployee(string mobile_Number)
        {
            var mobile_NumberParameter = mobile_Number != null ?
                new ObjectParameter("Mobile_Number", mobile_Number) :
                new ObjectParameter("Mobile_Number", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("proc_CheckAlreadyExistingEmployee", mobile_NumberParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> proc_GenerateEmployee_id(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("proc_GenerateEmployee_id", employee_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> proc_GetDepartmentId(string department_Name)
        {
            var department_NameParameter = department_Name != null ?
                new ObjectParameter("Department_Name", department_Name) :
                new ObjectParameter("Department_Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("proc_GetDepartmentId", department_NameParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> proc_GetUnitId(string unit_Name)
        {
            var unit_NameParameter = unit_Name != null ?
                new ObjectParameter("Unit_Name", unit_Name) :
                new ObjectParameter("Unit_Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("proc_GetUnitId", unit_NameParameter);
        }
    
        public virtual ObjectResult<proc_GetAllBusinessUnits_Result> proc_GetAllBusinessUnits()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetAllBusinessUnits_Result>("proc_GetAllBusinessUnits");
        }
    
        public virtual ObjectResult<proc_GetAllDepartments_Result> proc_GetAllDepartments()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetAllDepartments_Result>("proc_GetAllDepartments");
        }
    
        public virtual int proc_deleteEmployee(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_deleteEmployee", employee_idParameter);
        }
    
        public virtual ObjectResult<GetPeers_Result> GetPeers(Nullable<int> employee_id, Nullable<int> working_under)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            var working_underParameter = working_under.HasValue ?
                new ObjectParameter("working_under", working_under) :
                new ObjectParameter("working_under", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetPeers_Result>("GetPeers", employee_idParameter, working_underParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<proc_GetPeers_Result> proc_GetPeers(Nullable<int> employee_id, Nullable<int> working_under)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            var working_underParameter = working_under.HasValue ?
                new ObjectParameter("working_under", working_under) :
                new ObjectParameter("working_under", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetPeers_Result>("proc_GetPeers", employee_idParameter, working_underParameter);
        }
    
        public virtual int proc_InsertIntoWorkingUnder(Nullable<int> employee_id, Nullable<int> working_under)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            var working_underParameter = working_under.HasValue ?
                new ObjectParameter("working_under", working_under) :
                new ObjectParameter("working_under", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_InsertIntoWorkingUnder", employee_idParameter, working_underParameter);
        }
    
        public virtual ObjectResult<proc_ViewDetails_Result> proc_ViewDetails(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_ViewDetails_Result>("proc_ViewDetails", employee_idParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> proc_GetEmployeeIds(Nullable<int> employee_id)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("proc_GetEmployeeIds", employee_idParameter);
        }
    
        public virtual int procedure_InsertIntoWorkingUnder(Nullable<int> employee_id, Nullable<int> working_under, string first_Name, string last_Name, string email_id, string mobile_number)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            var working_underParameter = working_under.HasValue ?
                new ObjectParameter("working_under", working_under) :
                new ObjectParameter("working_under", typeof(int));
    
            var first_NameParameter = first_Name != null ?
                new ObjectParameter("First_Name", first_Name) :
                new ObjectParameter("First_Name", typeof(string));
    
            var last_NameParameter = last_Name != null ?
                new ObjectParameter("Last_Name", last_Name) :
                new ObjectParameter("Last_Name", typeof(string));
    
            var email_idParameter = email_id != null ?
                new ObjectParameter("Email_id", email_id) :
                new ObjectParameter("Email_id", typeof(string));
    
            var mobile_numberParameter = mobile_number != null ?
                new ObjectParameter("mobile_number", mobile_number) :
                new ObjectParameter("mobile_number", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("procedure_InsertIntoWorkingUnder", employee_idParameter, working_underParameter, first_NameParameter, last_NameParameter, email_idParameter, mobile_numberParameter);
        }
    
        public virtual ObjectResult<procedure_GetPeers_Result> procedure_GetPeers(Nullable<int> employee_id, Nullable<int> working_under)
        {
            var employee_idParameter = employee_id.HasValue ?
                new ObjectParameter("Employee_id", employee_id) :
                new ObjectParameter("Employee_id", typeof(int));
    
            var working_underParameter = working_under.HasValue ?
                new ObjectParameter("working_under", working_under) :
                new ObjectParameter("working_under", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<procedure_GetPeers_Result>("procedure_GetPeers", employee_idParameter, working_underParameter);
        }
    }
}
