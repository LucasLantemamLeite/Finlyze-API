using Finlyze.Migrations.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Finlyze.Api.Configuration.Builder;

public static class DependenceInjectionConfig
{
    public static IServiceCollection RegisterDependence(this IServiceCollection service, IConfiguration configuration)
    {

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        service.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

        return service;
    }
}