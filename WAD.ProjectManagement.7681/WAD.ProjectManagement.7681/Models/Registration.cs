using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WAD.ProjectManagement._7681.Models
{
    public class Registration : IValidatableObject
    {
            [Required]
            [Range(0, int.MaxValue)]
             public int RegistrationID { get; set; }

            [Required]
            public string Login { get; set; }

            [Required]
            [MinLength(5)]
            public string Password { get; set; }

            [Required]
            [Compare("Password")]
            public string ConfirmPassword { get; set; }

            public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
            {
                if (Login == Password)
                {
                    yield return new ValidationResult("Email and Password should not be the same", new[] { "Email" });
                }
            }
        }
    }

