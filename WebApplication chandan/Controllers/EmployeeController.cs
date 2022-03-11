using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_chandan.Models;

namespace WebApplication_chandan.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext db;
        public EmployeeController(EmployeeDbContext context)
        {
            db = context;

        }
        public IActionResult create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult create(Employee abc)
        {
            db.Employees.Add(abc);
            db.SaveChanges();
            return RedirectToAction ("Indext");
        }
    }
}
