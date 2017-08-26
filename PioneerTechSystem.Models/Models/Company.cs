using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechSystem.Models
{
    public class Company
    {
        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "Company Name is Mandatory")]
        public string CompanyName { get; set; }
        [Display(Name = "Company Contact Number")]
        [Required(ErrorMessage = "Contact Number is Mandatory")]
        public string CompanyContactNumber { get; set; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Location is Mandatory")]
        public string CompanyLocation { get; set; }
        [Display(Name = "Website Name")]
        [Required(ErrorMessage = "Website is Mandatory")]
        [DataType(DataType.Url)]
        public string CompanyWebsite { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
