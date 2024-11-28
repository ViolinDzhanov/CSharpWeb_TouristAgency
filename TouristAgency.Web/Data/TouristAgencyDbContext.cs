using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TouristAgency.Data.Models.Models;
using TouristAgency.Web.Data.Configurations;

namespace TouristAgency.Web.Data
{
    public class TouristAgencyDbContext : IdentityDbContext<Customer, IdentityRole<Guid>, Guid>
    {
        public TouristAgencyDbContext(DbContextOptions<TouristAgencyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<GuestRoom> GuestsRooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<GuestRoom>()
                .HasKey(gr => new { gr.GuestId, gr.RoomId });

            builder.ApplyConfiguration(new CountriesEntityConfiguration());
        }
    }
}
