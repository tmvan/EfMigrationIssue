using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfMigrationIssue.Entities;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace EfMigrationIssue
{
    public class SampleContext : DbContext
    {
        public SampleContext(DbContextOptions<SampleContext> options) : base(options)
        {
        }

        public DbSet<Classroom> Classrooms { get; set; }
        
        //public DbSet<Teacher> Teachers { get; set; }
    }
}
