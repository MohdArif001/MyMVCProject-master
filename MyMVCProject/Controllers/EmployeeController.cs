using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMVCProject.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace MyMVCProject.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplictionDbContext dbcontext;

        public IHostingEnvironment Environment { get; }

        public EmployeeController(ApplictionDbContext Context, IHostingEnvironment environment)
        {
            dbcontext = Context;
            Environment = environment;
        }
        public IActionResult Index()
        {
            var emps = dbcontext.employees.ToList();

            
            return View(emps);
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            
            var files = Request.Form.Files;
            string dbPath = String.Empty;
            if(files.Count>0)
            {
                string path = Environment.WebRootPath;
                string fullpath = Path.Combine(path, "images", files[0].FileName);
                dbPath = "images/" + files[0].FileName;
                FileStream  stream= new FileStream(fullpath, FileMode.Create);
                files[0].CopyTo(stream);
            }
            employee.Image = dbPath; 
            dbcontext.employees.Add(employee);
            dbcontext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult details()
        {
            return View();
        }
    }
}
