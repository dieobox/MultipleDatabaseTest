using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MultipleDatabase.Models;

namespace MultipleDatabase.Data
{
    public class MysqlDBContext : DbContext
    {

            public MysqlDBContext(DbContextOptions<MysqlDBContext> options) : base(options)
            {
            }

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                // Customize the ASP.NET Identity model and override the defaults if needed.
                // For example, you can rename the ASP.NET Identity table names and more.
                // Add your customizations after calling base.OnModelCreating(builder);
            }

       public DbSet<Student> Students { get; set; }

    }
}
