using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using School.Domain.Entities;
using School.Presistence.Data;

namespace School.Presistence
{
    public static class RegistrationModuleDependencies
    {
        public static IServiceCollection AddRegistrationModuleDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var connection = configuration.GetConnectionString("Database");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));


            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false;
                options.Password.RequiredUniqueChars = 0;

                options.SignIn.RequireConfirmedEmail = false;

                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.AllowedForNewUsers = true;
                options.Lockout.MaxFailedAccessAttempts = 5;

                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;


            })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();





            //Swagger Gn

            // you should remove this line from project refeernces <PackageReference Include="Swashbuckle.AspNetCore" Version="6.5.0" />

            // services.AddSwaggerGen(c =>
            // {
            //     c.SwaggerDoc("v1", new OpenApiInfo { Title = "AVMS Kiosk", Version = "v1" });
            //     c.EnableAnnotations();

            //     c.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
            //     {
            //         Description = "JWT Authorization header using the Bearer scheme (Example: 'Bearer 12345abcdef')",
            //         Name = "Authorization",
            //         In = ParameterLocation.Header,
            //         Type = SecuritySchemeType.ApiKey,
            //         Scheme = JwtBearerDefaults.AuthenticationScheme
            //     });

            //     c.AddSecurityRequirement(new OpenApiSecurityRequirement
            // {
            // {
            // new OpenApiSecurityScheme
            // {
            //     Reference = new OpenApiReference
            //     {
            //         Type = ReferenceType.SecurityScheme,
            //         Id = JwtBearerDefaults.AuthenticationScheme
            //     }
            // },
            // Array.Empty<string>()
            // }
            //});
            // });


            return services;
        }
    }
}
