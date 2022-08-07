using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MILTON_PROJECT.Models;
using MILTON_PROJECT.Repository;

namespace MILTON_PROJECT.Controllers
{
    public class StudentController : Controller
    {
        StudentsRepository studentsRepository = new StudentsRepository();

        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddStudent(Students students)
        {
            studentsRepository.AddNewStudent(students);
            return View();
        }

        [HttpGet]
        public ActionResult GetStudents()
        {
            return View();
        }
    }
}