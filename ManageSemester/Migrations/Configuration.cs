using System.Collections.Generic;
using ManageSemester.Models;

namespace ManageSemester.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ManageSemester.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "ManageSemester.DAL.SchoolContext";
        }

        protected override void Seed(ManageSemester.DAL.SchoolContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            var students = new List<Student>
            {
            new Student{FullName="Cornelius	Steele",Address="Ha Noi",Gender = true,DOB= DateTime.Parse("1991-9-1")},
            new Student{FullName="Alonzo Fletcher",Address="Sai Gon",Gender = true,DOB=DateTime.Parse("1992-10-3")},
            new Student{FullName="Rochelle Garcia",Address="Da Nang",Gender = false,DOB=DateTime.Parse("1993-4-22")},
            new Student{FullName="Veronica Coleman",Address="Dong 9",Gender = true,DOB=DateTime.Parse("1994-5-20")},
            new Student{FullName="Clinton Robinson",Address="Nghe An",Gender = true,DOB=DateTime.Parse("1995-9-15")},
            new Student{FullName="Hannah May",Address="Phu Tho",Gender = false,DOB=DateTime.Parse("1996-2-11")},
            new Student{FullName="Kendra Warren",Address="Hai Phong",Gender = true,DOB=DateTime.Parse("1997-11-16")},
            new Student{FullName="Oliver Franklin",Address="Ho Chi Minh",Gender = true,DOB=DateTime.Parse("1998-9-18")},
            new Student{FullName="Vicki Mccoy",Address="Ho Chi Minh",Gender = false,DOB=DateTime.Parse("1999-6-11")},
            new Student{FullName="Blake Knight",Address="Ho Chi Minh",Gender = false,DOB=DateTime.Parse("2000-9-13")}
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.FullName, s));
            context.SaveChanges();

            var courses = new List<Course>
            {
            new Course{CourseID=1050,Title="Toan",StartDate= DateTime.Parse("2018-1-1"),EndDate= DateTime.Parse("2029-2-1"), IsApproved = true},
            new Course{CourseID=4022,Title="Ly",StartDate= DateTime.Parse("2018-3-1"),EndDate= DateTime.Parse("2029-4-01"), IsApproved = true},
            new Course{CourseID=4041,Title="Hoa",StartDate= DateTime.Parse("2018-5-1"),EndDate= DateTime.Parse("2029-6-1"), IsApproved = true},
            new Course{CourseID=1045,Title="Van",StartDate= DateTime.Parse("2018-1-1"),EndDate= DateTime.Parse("2020-2-1"), IsApproved = true},
            new Course{CourseID=3141,Title="Su",StartDate= DateTime.Parse("2018-1-1"),EndDate= DateTime.Parse("2020-2-1"), IsApproved = true},
            new Course{CourseID=2021,Title="Dia",StartDate= DateTime.Parse("2018-1-1"),EndDate= DateTime.Parse("2020-2-1"), IsApproved = true},
            new Course{CourseID=2042,Title="The Duc",StartDate= DateTime.Parse("2018-1-1"),EndDate= DateTime.Parse("2020-2-1"), IsApproved = true}
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            //var enrollments = new List<Enrollment>
            //{
            //new Enrollment{StudentID = students.Single(s => s.FullName == "CarsonYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID },
            //new Enrollment{StudentID = students.Single(s => s.FullName == "MeredithYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "CarsonYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Macroeconomics" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "CarsonYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Calculus" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "MeredithYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Trigonometry" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "CarsonYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Composition" ).CourseID,},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "ArturoYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "GytisYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Microeconomics" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "YanYanTee").ID,
            //    CourseID = courses.Single(c => c.Title == "Composition" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "PeggyYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Literature" ).CourseID},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "LauraYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID,},
            //new Enrollment{StudentID = students.Single(s => s.FullName == "NinoYan").ID,
            //    CourseID = courses.Single(c => c.Title == "Chemistry" ).CourseID}
            //};
            //foreach (Enrollment e in enrollments)
            //{
            //    var enrollmentInDataBase = context.Enrollments.Where(
            //        s =>
            //            s.Student.ID == e.StudentID &&
            //            s.Course.CourseID == e.CourseID).SingleOrDefault();
            //    if (enrollmentInDataBase == null)
            //    {
            //        context.Enrollments.Add(e);
            //    }
            //}
            //context.SaveChanges();
        }
    }
}

