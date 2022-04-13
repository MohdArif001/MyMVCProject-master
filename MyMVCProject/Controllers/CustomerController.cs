using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyMVCProject.Models;

namespace MyMVCProject.Controllers
{
    public class CustomerController : Controller
    {
        //private CustomerDbOperation dbOperation; //object
        private ApplictionDbContext dbContext;
        public CustomerController(ApplictionDbContext _dbContext)
        {
            dbContext = _dbContext;
            //dbOperation = new CustomerDbOperation();  //Instance
        }
        public IActionResult Index()
        {
            //var Customers = dbContext.customers.ToList();
            //var Customers = dbOperation.mCustomers();
            var Locations = dbContext.Location.ToList();
            return View(Locations);
        }
        public IActionResult CustomerList(int id)
        {
            var Customers = dbContext.customers.Where(e => e.location.Myproperty == id);
            return View(Customers);
        }
        public IActionResult CustomerDetails(int id)
        {
            var Customer = dbContext.customers.SingleOrDefault(e => e.Id == id);
            return View(Customer);
        }

    }
}
