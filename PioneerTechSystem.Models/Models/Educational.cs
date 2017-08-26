using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechSystem.Models
{
    public class Educational
    {
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
        [Display(Name = "Course Type")]
        [Required(ErrorMessage = "Course Type is Mandatory")]
        public string CourseType { get; set; }
        [Display(Name = "Specialization")]
        [Required(ErrorMessage = "Specialization is Mandatory")]
        public string CourseSpecialization { get; set; }
        [Display(Name = "Year of Passing")]
        [Required(ErrorMessage = "Year of Passing is Mandatory")]
        public string CourseYearofPassing { get; set; }
    }
}
