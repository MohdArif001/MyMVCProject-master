using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyMVCProject.Models
{
    public class ApplictionDbContext : DbContext
    {
        //public ApplicationDbContext() : base() { }
        public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options) : base(options) { }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
        
}
