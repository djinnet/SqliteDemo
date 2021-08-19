using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SqliteDemo
{
    public class ApplicationDBContext:DbContext
    {
        public DbSet<Depts> Dept { get; set; }

        public ApplicationDBContext()
            :base()
        {

        }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            :base(options)
        {

        }
    }
}
