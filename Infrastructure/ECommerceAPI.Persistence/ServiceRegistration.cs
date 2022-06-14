using ECommerceAPI.Persistence.DAL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Persistence.Repositories;

namespace ECommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            //services.AddDbContext<ECommerceAppDbContext>(options =>
            //{
            //    options.UseNpgsql("User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=ECommerceAPIDb;Integrated Security=true;");
            //});

            services.AddScoped<ICustomerQueryRepository, CustomerQueryRepository>();
            services.AddScoped<ICustomerCommandRepository, CustomerCommandRepository>();
            services.AddScoped<IProductQueryRepository, ProductQueryRepository>();
            services.AddScoped<IProductCommandRepository, ProductCommandRepository>();
            services.AddScoped<IOrderQueryRepository, OrderQueryRepository>();
            services.AddScoped<IOrderCommandRepository, OrderCommandRepository>();


        }
    }
}
