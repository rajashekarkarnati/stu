//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentRepositorySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web.Mvc;

    public partial class StudentDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentDetail()
        {
            this.JobsApplieds = new HashSet<JobsApplied>();
        }
    
        public int studentid { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string studentname { get; set; }
        [Required(ErrorMessage = "Age cannot be empty")]
        public int age { get; set; }

        [Display(Name = "Gender")]
        public string gender { get; set; }
        public System.DateTime dob { get; set; }
        [Required(ErrorMessage = "Mobile No cannot be empty")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile no")]
        public string mobileno { get; set; }
        [Required(ErrorMessage = "Address cannot be empty")]
        public string address { get; set; }
        [Required(ErrorMessage = "Password cannot be empty")]
        [RegularExpression(@"^(?=(.*[a-z]){1,})(?=(.*[\d]){1,})(?=(.*[\W]){1,})(?!.*\s).{7,30}$",
         ErrorMessage = "Password must have one Special character and 1 numeric and 1 uppercase and must have min 8 characters long")]
        public string password { get; set; }

        public string photo { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        [Remote("IsAlreadySigned", "Login", HttpMethod = "POST", ErrorMessage = "EmailId already exists.")]
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JobsApplied> JobsApplieds { get; set; }
    }
}