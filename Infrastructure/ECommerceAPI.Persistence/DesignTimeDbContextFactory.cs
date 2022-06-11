using ECommerceAPI.Persistence.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
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
            DbContextOptionsBuilder<ECommerceAppDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql("User ID=rasulquliyevv;Password=rq020314.;Host=localhost;Port=5432;Database=ECommerceAPIDb");
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
