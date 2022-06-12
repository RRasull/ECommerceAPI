using ECommerceAPI.Persistence.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceAppDbContext>
    {
        public ECommerceAppDbContext CreateDbContext(string[] args)
        {
            //ConfigurationManager configurationManager = new();
            //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceAPI.API"));
            //configurationManager.AddJsonFile("appsettings.json");

            DbContextOptionsBuilder<ECommerceAppDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);

            return new(dbContextOptionsBuilder.Options);
        }
    }
}
