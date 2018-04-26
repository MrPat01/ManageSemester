using System;
using System.Collections.Generic;
using ManageSemester.Models;

namespace ManageSemester.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>

    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{FullName="Carson",Address="Ha Noi",Gender = true,DOB= DateTime.Parse("2005-09-01")},
            new Student{FullName="Meredith",Address="Sai Gon",Gender = true,DOB=DateTime.Parse("2002-09-01")},
            new Student{FullName="Arturo",Address="Da Nang",Gender = false,DOB=DateTime.Parse("2003-09-01")},
            new Student{FullName="Gytis",Address="Dong 9",Gender = true,DOB=DateTime.Parse("2002-09-01")},
            new Student{FullName="Yan",Address="Nghe An",Gender = true,DOB=DateTime.Parse("2002-09-01")},
            new Student{FullName="Peggy",Address="Phu Tho",Gender = false,DOB=DateTime.Parse("2001-09-01")},
            new Student{FullName="Laura",Address="Hai Phong",Gender = true,DOB=DateTime.Parse("2003-09-01")},
            new Student{FullName="Nino",Address="Ho Chi Minh",Gender = true,DOB=DateTime.Parse("2005-09-01")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Chemistry",StartDate= DateTime.Parse("2018-01-01"),EndDate= DateTime.Parse("2005-02-01"), IsApproved = true},
            new Course{CourseID=4022,Title="Microeconomics",StartDate= DateTime.Parse("2018-03-01"),EndDate= DateTime.Parse("2005-04-01"), IsApproved = true},
            new Course{CourseID=4041,Title="Macroeconomics",StartDate= DateTime.Parse("2018-05-01"),EndDate= DateTime.Parse("2005-06-01"), IsApproved = true},
            new Course{CourseID=1045,Title="Calculus",StartDate= DateTime.Parse("2018-01-01"),EndDate= DateTime.Parse("2005-02-01"), IsApproved = true},
            new Course{CourseID=3141,Title="Trigonometry",StartDate= DateTime.Parse("2018-01-01"),EndDate= DateTime.Parse("2005-02-01"), IsApproved = true},
            new Course{CourseID=2021,Title="Composition",StartDate= DateTime.Parse("2018-01-01"),EndDate= DateTime.Parse("2005-02-01"), IsApproved = true},
            new Course{CourseID=2042,Title="Literature",StartDate= DateTime.Parse("2018-01-01"),EndDate= DateTime.Parse("2005-02-01"), IsApproved = true}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050},
            new Enrollment{StudentID=1,CourseID=4022},
            new Enrollment{StudentID=1,CourseID=4041},
            new Enrollment{StudentID=2,CourseID=1045},
            new Enrollment{StudentID=2,CourseID=3141},
            new Enrollment{StudentID=2,CourseID=2021},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022},
            new Enrollment{StudentID=5,CourseID=4041},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}