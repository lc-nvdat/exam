using ExamASP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExamASP.Context
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}