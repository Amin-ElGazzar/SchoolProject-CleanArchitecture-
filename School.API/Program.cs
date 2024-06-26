using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using School.Application;
using School.Application.Middleware;
using School.Presistence;
using School.Service;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Connection  to sql server
//builder.Services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("Database")));

#region Dependencies
builder.Services.AddApplicationDependancies(builder.Configuration)
                .AddPresistenceDependencies()
                .AddRegistrationModuleDependencies(builder.Configuration)
                .AddServiceDependencies();
#endregion

#region Localization
builder.Services.AddLocalization(opt =>
{
    opt.ResourcesPath = "";
});
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    List<CultureInfo> supportedCultures = new List<CultureInfo>
    {
            new CultureInfo("en-US"),
            new CultureInfo("ar-EG")
    };

    options.DefaultRequestCulture = new RequestCulture("en-US");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});
#endregion
var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseMiddleware<ExceptionHandlerMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();
#region Localization Middleware
app.UseRequestLocalization(app.Services.GetService<IOptions<RequestLocalizationOptions>>().Value);

#endregion


app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
