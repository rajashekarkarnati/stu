using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentRepositorySystem.ViewModel
{
    public class ChangePassword
    {
        [Key]
        public int studentid { get; set; }
        public string oldpassword { get; set; }
        [Required(ErrorMessage = "New Password cannot be empty")]
        [RegularExpression(@"^(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{7,30}$",
 ErrorMessage = "New Password must have one Special character and 1 numeric and 1 uppercase and must have min 8 characters long")]
        public string newpassword { get; set; }
        [Required(ErrorMessage = "Confrim Password cannot be empty")]
        [RegularExpression(@"^(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{7,30}$",
 ErrorMessage = "Confirm Password must have one Special character and 1 numeric and 1 uppercase and must have min 8 characters long")]
        [Compare(nameof(newpassword), ErrorMessage = "Confirm Password Must Match with New Password")]
        public string confirmpassword { get; set; }
    }
}