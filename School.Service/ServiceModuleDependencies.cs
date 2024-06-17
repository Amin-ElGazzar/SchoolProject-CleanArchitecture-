using Microsoft.Extensions.DependencyInjection;
using School.Application.Contracts.Services;
using School.Service.Authentication;

namespace School.Service
{
    public static class ServiceModuleDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationServices>();

            return services;
        }
    }
}
