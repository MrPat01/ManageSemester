using System.Linq;
using ManageSemester.DAL;
using ManageSemester.ViewModels;
using System.Web.Mvc;

namespace ManageSemester.Controllers
{
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            IQueryable<EnrollmentByCourseGroup> data = from student in db.Students
                                                       join enrollment in db.Enrollments on student.ID equals enrollment.StudentID
                                                       join course in db.Courses on enrollment.CourseID  equals course.CourseID
                                                       group student by new {enrollment.CourseID, course.Title} into courseGroup
                                                       select new EnrollmentByCourseGroup()
                                                       {
                                                           CourseID = courseGroup.Key.CourseID,
                                                           CourseTitle = courseGroup.Key.Title,
                                                           StudentCount = courseGroup.Count()
                                                       };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Manage Semester contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}