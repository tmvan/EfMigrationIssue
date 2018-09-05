using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EfMigrationIssue
{
    public static class IocConfig
    {
        public const string CONNECTION_STRING = "Server=(LocalDB)\\MSSQLLocalDB;Database=SampleContext-EfMigrationIssue;Trusted_Connection=True";

        public const string BADCONTEXT_CONNECTION_STRING = "Server=(LocalDB)\\MSSQLLocalDB;Database=BadSampleContext-EfMigrationIssue;Trusted_Connection=True";

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SampleContext>(
                options => options.UseSqlServer(CONNECTION_STRING));

            services.AddDbContext<BadSampleContext>(
                options => options.UseSqlServer(BADCONTEXT_CONNECTION_STRING));
        }
    }
}
