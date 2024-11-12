using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Data.Models.Models;

namespace TouristAgency.Web.Data
{
    public class TouristAgencyDbContext : IdentityDbContext
    {
        public TouristAgencyDbContext()
        {
            
        }
        public TouristAgencyDbContext(DbContextOptions<TouristAgencyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<Customer> Customers { get; set; }
    }
}
