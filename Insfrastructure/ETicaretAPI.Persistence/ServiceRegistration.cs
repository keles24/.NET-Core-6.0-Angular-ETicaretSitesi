using ETicaretAPI.Application.Abstractions;
using ETicaretAPI.Persistence.Concreates;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Persistence.Repository;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICostumerReadRepository,CostumerReadRepository>();
            services.AddScoped<ICostumerWriteRepository,CostumerWriteRepository>();
            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
        }
    }
}
