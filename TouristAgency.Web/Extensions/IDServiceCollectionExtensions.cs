﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TouristAgency.Data.Models.Models;
using TouristAgency.Web.Data;

namespace TouristAgency.Web.Extensions
{
    public static class IDServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationDatabase(this IServiceCollection services,
            IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Add services to the container.
            services.AddDbContext<TouristAgencyDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services,
           IConfiguration configuration)
        {
           services.AddIdentity<Customer, IdentityRole<Guid>>(options => options.SignIn.RequireConfirmedAccount = true)
               .AddEntityFrameworkStores<TouristAgencyDbContext>()
               .AddDefaultTokenProviders()
               .AddDefaultUI();

            return services;
        }

        public static IServiceCollection AddApplicationServices(this IServiceCollection services,
           IConfiguration configuration)
        {
            return services;
        }
    }
}