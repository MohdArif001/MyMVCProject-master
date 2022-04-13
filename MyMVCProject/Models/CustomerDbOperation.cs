using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMVCProject.Models
{
    public class CustomerDbOperation
    {
       private List<Customer> Customers;
        public CustomerDbOperation()
        {
            Customers = new List<Customer>()
            {
                new Customer(){Id=1,Name="Sanjay",Email="sanjay123@gmail.com",Mobile="9690266327",Gender="Male"},
                new Customer(){Id=2,Name="Rohan",Email="rohan234@gmail.com",Mobile="956823546",Gender="Male"},
                new Customer(){Id=3,Name="Sumit",Email="sumit678@gmail.com",Mobile="8659236520",Gender="Male"},
                new Customer(){Id=4,Name="Varun",Email="varun899@gmail.com",Mobile="785469231",Gender="Male"},
            };
        }
        public List<Customer>mCustomers()
        {
            return this.Customers;
        }
    }
}
