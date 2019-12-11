using rest.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace rest.Context
{
    public class RestDbContext : DbContext
    {
        public IDbSet<Course> Courses { get; set; }
        public RestDbContext() :base("RestDbContextName")
        {
            
        }
    }
}