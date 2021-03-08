using ISTTest.Infrastructure;
using ISTTest.Infrastructure.Data;
using ISTTest.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISTTest.Extensions
{
    public static class ApplicationServices
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<StoreContext>(options =>
             options.UseSqlServer(configuration.GetConnectionString("Default")));

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            return services;

        }
    }
}
