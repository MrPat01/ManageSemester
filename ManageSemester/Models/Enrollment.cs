using System.ComponentModel.DataAnnotations;

namespace ManageSemester.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        [Required]
        public int CourseID { get; set; }
        [Required]
        public int StudentID { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}