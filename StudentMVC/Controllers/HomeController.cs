using Microsoft.AspNetCore.Mvc;
using System;
using StudentMVC.Models;

namespace StudentMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/Index
        // Displays current date/time, your name, roll no, and multiplication table of (roll no + 1)
        public IActionResult Index()
        {
            int rollNo = 62;
            int tableNumber = rollNo + 1;

            ViewBag.CurrentDateTime = DateTime.Now;
            ViewBag.Name = "Subash Chand Thakuri";
            ViewBag.RollNo = rollNo;
            ViewBag.TableNumber = tableNumber;

            return View();
        }

        // GET: /Home/CreateStudent
        // Displays a form to enter student details.
        [HttpGet]
        public IActionResult CreateStudent()
        {
            return View();
        }

        // POST: /Home/CreateStudent
        // Processes the form submission.
        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            if (ModelState.IsValid)
            {
                // Passing data using TempData for simplicity.
                TempData["StdID"] = student.StdID;
                TempData["Name"] = student.Name;
                TempData["Address"] = student.Address;
                TempData["Faculty"] = student.Faculty;

                return RedirectToAction("StudentDetails");
            }
            return View(student);
        }

        // GET: /Home/StudentDetails
        // Displays the student details.
        public IActionResult StudentDetails()
        {
            Student student = new Student
            {
                StdID = TempData["StdID"] != null ? Convert.ToInt32(TempData["StdID"]) : 0,
                Name = TempData["Name"] as string,
                Address = TempData["Address"] as string,
                Faculty = TempData["Faculty"] as string
            };

            return View(student);
        }
    }
}
