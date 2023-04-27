using ETradeAPI.Application.Abstractions;
using ETradeAPI.Persistence.Concrete;
using ETradeAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETradeAPI.Application.Repositories;
using ETradeAPI.Persistence.Repositories;

namespace ETradeAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETradeAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();

            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

            services.AddScoped<IOrderReadRepository, OrderReadRepository>();

            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();

            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        }
    }
}
