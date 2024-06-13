using Microsoft.Extensions.DependencyInjection;
using School.Application.Contracts.Repositories;
using School.Presistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Presistence
{
    public static class PresistenceModuleDependencies
    {
        public static IServiceCollection AddPresistenceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
