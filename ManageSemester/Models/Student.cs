using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManageSemester.Models
{
    public class Student
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string FullName { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Address { get; set; }

        public bool Gender { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}