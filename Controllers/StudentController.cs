using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemoApp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListStudent()
        {
            List<StudentModel> student = new List<StudentModel>();
            student.Add(new StudentModel { FirstName = "John", LastName = "Doe", Major="Business", Course="Distributed Info" });
            student.Add(new StudentModel { FirstName = "Jane", LastName = "Doe", Major = "Accounting", Course = "Financial Acct 1" });
            student.Add(new StudentModel { FirstName = "Michael", LastName = "Jay", Major = "Engineer", Course = "Mechanical 1" });
            // Get the list to the view
            return View(student);
        }
        [HttpGet]
        public ActionResult Edit( int id)
        {
            StudentModel student = new StudentModel();
            

            return View("Edit",student);
        
        }
    }
}