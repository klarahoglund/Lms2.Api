using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lms2.Core.Entities;

namespace Lms2.Data.Data
{
    public class Lms2ApiContext : DbContext
    {
        public Lms2ApiContext(DbContextOptions<Lms2ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Course { get; set; } = default!;

        public DbSet<Module>? Module { get; set; }
    }
}
