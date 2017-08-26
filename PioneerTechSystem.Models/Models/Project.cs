using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTechSystem.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        [Display(Name = "Project Name")]
        [Required(ErrorMessage = "Project Name is Mandatory")]
        public string ProjectName { get; set; }
        [Display(Name = "Client Name")]
        [Required(ErrorMessage = "Client Name is Mandatory")]
        public string ClientName { get; set; }
        [Display(Name = "Project Location")]
        [Required(ErrorMessage = "Project Location is Mandatory")]
        public string ProjectLocation { get; set; }
        [Display(Name = "Project Roles")]
        [Required(ErrorMessage = "Project Roles is Mandatory")]
        public string ProjectRoles { get; set; }
        public int EmployeeID { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
