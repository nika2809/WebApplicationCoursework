using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.ProjectManagement._7681.Models
{
    public class Project
    {

        [Required]
        [Range(0, int.MaxValue)]
        public int ProjectID { get; set; }

        [Required]
        [MinLength(2)]
        public string ProjectName { get; set; }

        [Required]
        public string CooperationOrganization { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public string ProjectDetails { get; set; }

        [Required]
        public Company Company { get; set; }


    }

    public enum Company
    {
        DNAUzbekistan,
        DinaraMediaRelations,
        VisitUzbekistan,
        DynamicUzbekistan
    }
}

