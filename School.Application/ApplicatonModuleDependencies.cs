using FluentValidation;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School.Application.Behavior;
using School.Application.Common.Models;
using System.Reflection;

namespace School.Application
{
    public static class ApplicatonModuleDependencies
    {
        public static IServiceCollection AddApplicationDependancies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(opt => opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            services.Configure<Jwt>(configuration.GetSection("Jwt"));

            return services;
        }
    }
}
