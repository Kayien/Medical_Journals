using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HSMedicalJournalsDB.Models
{
    public class User
    {
        public User()
        {
            EmailConfirmed = 0;
            Registration = DateTime.Now;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "E-Mail")]        
        public string Email { get; set; }
                
        public int EmailConfirmed { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Password Confirmation")]
        [Compare("Password",ErrorMessage = "Must confirm your password")]
        [DataType(DataType.Password)]
        public string PasswordConfirmation { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(50)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime Registration { get; set; }
    }
}