using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;



namespace CourseApp.Controllers
{
    //localhost:5000/course
    public class CourseController : Controller
    {
        //Action method
        //localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        //localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            var students = Repository.Students.Where(i => i.Confirm == true);
            return View(students);
        }

        //localhost:5000/course/apply => course/apply.cshtml => method: Get
        [HttpGet]
        public IActionResult Apply()
        {

            return View();
        }

        //localhost:5000/course/apply => course/apply.cshtml => method: POST
        [HttpPost]
        public IActionResult Apply(Student student)
        {
            //Model Binding
            //database kayıt

            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            return View(student);
        }


        public IActionResult Details()
        {

            var course = new Course();

            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }
    }
}