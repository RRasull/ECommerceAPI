using ECommerceAPI.Persistence.DAL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ECommerceAppDbContext>(options =>
            {
                options.UseNpgsql("User ID=rasulquliyevv;Password=rq020314.;Host=localhost;Port=5432;Database=ECommerceAPIDb");
            });


        }
    }
}
