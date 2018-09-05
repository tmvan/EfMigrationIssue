using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfMigrationIssue.Data
{
    public class BadSampleContextDesignTimeDbContextFactory : IDesignTimeDbContextFactory<BadSampleContext>
    {
        public BadSampleContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<BadSampleContext>();
            builder.UseSqlServer(IocConfig.BADCONTEXT_CONNECTION_STRING);
            return new BadSampleContext(builder.Options);
        }
    }
}
