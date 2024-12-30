using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Primeclass_Airport.Domain.Context;

namespace Primeclass_Airport.Api.IOC;

public static class Dependencies
{
    public static void DependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
        //sql connection
        services.AddDbContext<SqlServerDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("PrimeClassLocal"));
        });

        //generic repository

        //non generic repositories

        //add mapper

        //my services

        //google services

        //jwt
    }
}
