using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MVC_BasicTutorial.DataMapper;


namespace MVC_BasicTutorial.Models
{
    public class EmployeeDBContext : DbContext
    {

        public EmployeeDBContext() : base("DefaultConnection")
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMapper());
        }

    }
}