using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoCard.Data
{
    public class SmoCardContextFactory : IDesignTimeDbContextFactory<SmoCardContext>
    {
        public SmoCardContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var builder = new DbContextOptionsBuilder<SmoCardContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new SmoCardContext(builder.Options);
        }
    }
}
