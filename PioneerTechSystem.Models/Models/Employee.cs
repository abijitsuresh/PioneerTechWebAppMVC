using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is mandatory")]
        [StringLength(50, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is mandatory")]
        [StringLength(50, MinimumLength = 2)]
        public string LastName { get; set; }
        [Display(Name = "Email ID")]
        [Required(ErrorMessage = "Email ID is mandatory")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter a valid Email ID.")]
        public string EmailID { get; set; }
        [Display(Name = "Mobile Number")]
        [Required(ErrorMessage = "Mobile Number is mandatory")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please enter a valid US Mobile Number.")]
        public string MobileNumber { get; set; }
        [Display(Name = "Alternate Mobile Number")]
        public string AlternateMobileNumber { get; set; }
        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "Address is mandatory")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Display(Name = "State")]
        [Required(ErrorMessage = "State is mandatory")]
        public string AddressState { get; set; }
        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is mandatory")]
        public string AddressCountry { get; set; }
        [Display(Name = "Zip Code")]
        [DataType(DataType.PostalCode)]
        [Required(ErrorMessage = "Zip Code is mandatory")]
        public string AddressZipCode { get; set; }
        [Display(Name = "Home Country")]
        [Required(ErrorMessage = "Home country is mandatory")]
        public string HomeCountry { get; set; }
        public virtual Company Company { get; set; }
        public virtual Project Project { get; set; }
        public virtual Technical Technical { get; set; }
        public virtual Educational Educational { get; set; }
    }
}
