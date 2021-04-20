using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ProjectManagementTool.DAL;

namespace ProjectManagementTool.DAL.DBO
{
    public class Member
    {
        [Required]
        [Range(0, int.MaxValue)]
        [Key]
        public int MemberID { get; set; }

        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public Project Project { get; set; }

      public virtual ICollection<Project> Projects { get; set; }
    }


}
