using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_BasicTutorial.Models
{
    public class Employee
    {
        public int EmpId { get; set; }
        [Required(ErrorMessage ="First name is required.")]
        [StringLength(15,MinimumLength =3, ErrorMessage ="Invalid Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Invalid Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Gender is required.")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email Id is required.")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage ="Enter Valid Email Address")]
        public string EmailId { get; set; }

        [RegularExpression(@"^\d{10}$", ErrorMessage = "Enter valid Phone Number")]
        [Required(ErrorMessage ="Phone Number is required.")]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Designation is required.")]
        public string Designation { get; set; }

        [Required(ErrorMessage = "Reporting Manager is required.")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Invalid Name")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Invalid Name")]
        public string ReportingManager { get; set; }
    }
}