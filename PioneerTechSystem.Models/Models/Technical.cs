using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechSystem.Models
{
    public class Technical
    {
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        [Display(Name = "Programming Languages")]
        [Required(ErrorMessage = "Programming Languages is Mandatory")]
        public string ProgrammingLanguages { get; set; }
        [Display(Name = "Databases Known")]
        [Required(ErrorMessage = "Databases Known is Mandatory")]
        public string DatabasesKnown { get; set; }
        [Display(Name = "ORM Technologies")]
        [Required(ErrorMessage = "ORM Technologies is Mandatory")]
        public string ORMTechnologies { get; set; }
        [Display(Name = "UI Technologies")]
        [Required(ErrorMessage = "UI Technologies is Mandatory")]
        public string UITechnologies { get; set; }
    }
}
