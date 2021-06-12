using ASP_dot_NET_Core_MVC_Course_dot_NET5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_dot_NET_Core_MVC_Course_dot_NET5.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Disable "Lazy Loading"
            //ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Employee> Employee { get; set; }
    }
}
