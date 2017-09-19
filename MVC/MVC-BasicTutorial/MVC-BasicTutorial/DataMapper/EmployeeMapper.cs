using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data.Entity.ModelConfiguration;
using System.Threading.Tasks;
using MVC_BasicTutorial.Models;

namespace MVC_BasicTutorial.DataMapper
{
    public class EmployeeMapper : EntityTypeConfiguration<Employee>
    {
        public EmployeeMapper()
        {
            ToTable("Employees");
            Property(x => x.EmpId).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            HasKey(t => t.EmpId);
            Property(y => y.FirstName).HasColumnName("Firstname");
            Property(z => z.EmpId).HasColumnName("EmployeeId");
            Property(y => y.LastName).HasColumnName("Lastname");
            Property(z => z.Gender).HasColumnName("Gender");
            Property(y => y.EmailId).HasColumnName("Emailid");
            Property(z => z.PhoneNo).HasColumnName("Phoneno");
            Property(y => y.Address).HasColumnName("Address");
            Property(z => z.Designation).HasColumnName("Designation");
            Property(y => y.ReportingManager).HasColumnName("Reportingmanager");
        }
    }
}