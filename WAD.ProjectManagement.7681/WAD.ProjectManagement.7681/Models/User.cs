using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.ProjectManagement._7681.Models
{
    public class User
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int UsetID { get; set; }

        [Required]
        [Range(0, int.MaxValue)]

        public int UserID { get; set; }

        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]

        public DateTime DateofBirth { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Position Position { get; set; }

    }

    public enum Position
    {
        Intern,
        OfficeManager,
        ProjectManager,
        PRManager,
        SalesManager,
        Designer,
        Author
    }

    public enum Gender
    {
        Male,
        Female
    }
}

