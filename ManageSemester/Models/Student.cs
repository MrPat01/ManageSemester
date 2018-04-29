using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Configuration;

namespace ManageSemester.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Display(Name = "Full Name")]
        [Required]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Full name cannot be longer than 50 or less than 6 characters.")]
        public string FullName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Address { get; set; }

        public bool Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }

        //For example the following code requires the first character to be upper case and the remaining characters to be alphabetical:
        //[RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
    }
}