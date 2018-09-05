using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfMigrationIssue.BadEntities;
using Microsoft.EntityFrameworkCore;

namespace EfMigrationIssue
{
    public class BadSampleContext : DbContext
    {
        public BadSampleContext(DbContextOptions<BadSampleContext> options) : base(options)
        {
        }

        public DbSet<BadClassroom> Classrooms { get; set; }
        
        //public DbSet<BadTeacher> Teachers { get; set; }
    }
}
