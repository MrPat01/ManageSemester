using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ManageSemester.Models;

namespace ManageSemester.ViewModels
{
    public class CourseIndexData
    {
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Enrollment> Enrollments { get; set; }
    }
}