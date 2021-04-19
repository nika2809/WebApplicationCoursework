using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagementTool.Models
{
    public class Project
    {
        
        [Range(0, int.MaxValue)]
        public int ProjectID { get; set; }

        [Required]
        [MinLength(2)]
        public string ProjectName { get; set; }

        [Required]
        public string CooperationOrganization { get; set; }

        [Required]
        [MinLength(2)]
        public string ProjectDetails { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartTime { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndTime { get; set; }

    }
}
