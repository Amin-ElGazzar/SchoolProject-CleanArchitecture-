using Microsoft.Extensions.DependencyInjection;
using School.Application.Contracts.Services;
using School.Service.Authentication;
using School.Service.Token;

namespace School.Service
{
    public static class ServiceModuleDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationServices>();
            services.AddScoped<ITokenService, TokenService>();

            return services;
        }
    }
}
