using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EfMigrationIssue
{
    public class SampleContextDesignTimeDbContextFactory : IDesignTimeDbContextFactory<SampleContext>
    {
        public SampleContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SampleContext>();
            builder.UseSqlServer(IocConfig.CONNECTION_STRING);
            return new SampleContext(builder.Options);
        }
    }
}
