using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Teacher.Models;

namespace Teacher.Data
{
    public class SchoolDBContext:DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}