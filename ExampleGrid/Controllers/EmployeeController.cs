using ExampleGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleGrid.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var employees = new List<Employee>
            {
                new Employee(1, "Rahual Bose", "72/A1", "Boston", "AP", "123123", "Male", "Project Manager", "Project Lead", 50000, "5"),
                new Employee(2, "John Doe", "46 High Street", "Birkenhead", "Merseyside", "AB12 3CD", "Male", "Development Manager", "Developer", 55000, "2"),
                new Employee(3, "Jane Doe", "67 Lower Road", "Birkenhead", "Merseyside", "FG56 7ES", "Female", "Developer", "Developer", 49000, "3")
            };

            return View(employees);
        }

        public ActionResult Edit(int id)
        {
            return Index();
        }
    }
}
