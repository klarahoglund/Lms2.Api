using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lms2.Core.Entities;

namespace Lms2.Api.Data
{
    public class Lms2ApiContext : DbContext
    {
        public Lms2ApiContext (DbContextOptions<Lms2ApiContext> options)
            : base(options)
        {
        }

        public DbSet<Lms2.Core.Entities.Course> Course { get; set; } = default!;

        public DbSet<Lms2.Core.Entities.Module>? Module { get; set; }
    }
}
