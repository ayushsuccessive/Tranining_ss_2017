using MVC_BasicTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_BasicTutorial;
using System.Data.Entity.Validation;

namespace MVC_BasicTutorial.Managers
{
    public class EmployeeManager
    {
        private EmployeeDBContext Db = new EmployeeDBContext();
        public void SaveData( Employee model)
        {
            Employee Emp = new Employee
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Gender = model.Gender,
                EmailId = model.EmailId,
                PhoneNo = model.PhoneNo,
                Designation = model.Designation,
                ReportingManager = model.ReportingManager,
                Address = model.Address
            };
            
            try
            {
                Db.Employees.Add(Emp);
                Db.SaveChanges();
                Db.Dispose();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        var v = validationError.PropertyName + "," + validationError.ErrorMessage;
                    }
                }
            }
        }

        internal void EditData(Employee model)
        {
            
            try
            {
                var Emp = Db.Employees.Where(s => s.EmpId == model.EmpId).FirstOrDefault();
                Emp.FirstName = model.FirstName;
                Emp.LastName = model.LastName;
                Emp.Gender = model.Gender;
                Emp.EmailId = model.EmailId;
                Emp.PhoneNo = model.PhoneNo;
                Emp.Designation = model.Designation;
                Emp.ReportingManager = model.ReportingManager;
                Emp.Address = model.Address;
                Db.SaveChanges();
                Db.Dispose();
            }
            catch { }
        }

        internal void DeleteData(int empid)
        {
            try
            {
                var Emp = Db.Employees.Where(s => s.EmpId == empid).FirstOrDefault();
                Db.Employees.Remove(Emp);
                Db.SaveChanges();
                Db.Dispose();
            }
            catch { }
        }
    }
}