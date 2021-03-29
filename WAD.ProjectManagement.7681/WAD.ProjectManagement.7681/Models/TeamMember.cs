using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.ProjectManagement._7681.Models
{
    public class TeamMember
    {
        [Required]
        [Range(0, int.MaxValue)]

        public int MemberID { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Team Team { get; set; }

    }

    public enum Team
    {
        Project,
        Publishing,
        Sales,
        Management

    }
}

