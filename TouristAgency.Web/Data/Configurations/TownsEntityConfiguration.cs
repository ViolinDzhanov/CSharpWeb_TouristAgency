using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Data.Models.Models;

namespace TouristAgency.Web.Data.Configurations
{
    public class TownsEntityConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            ICollection<Town> towns = CreateTowns();
            builder.HasData(towns);
        }

        private ICollection<Town> CreateTowns()
        {
            List<Town> towns = new List<Town>()
            {
                new Town()
                {
                    Name = "Sofia",
                    CountryId = Guid.Parse("D225932B-E49B-4F30-89A3-A1863C6857F6")
                },
                new Town()
                {
                    Name = "Plovdiv",
                    CountryId = Guid.Parse("D225932B-E49B-4F30-89A3-A1863C6857F6")
                },
                new Town()
                {
                    Name = "Varna",
                    CountryId = Guid.Parse("D225932B-E49B-4F30-89A3-A1863C6857F6")
                },
                new Town()
                {
                    Name = "Athens",
                    CountryId = Guid.Parse("360218CE-ABBB-4DDF-A0D3-0900DAB63843")
                },
                new Town()
                {
                    Name = "Thessaloniki",
                    CountryId = Guid.Parse("360218CE-ABBB-4DDF-A0D3-0900DAB63843")
                },
                new Town()
                {
                    Name = "Patras",
                    CountryId = Guid.Parse("360218CE-ABBB-4DDF-A0D3-0900DAB63843")
                },
                new Town()
                {
                    Name = "Rome",
                    CountryId = Guid.Parse("8A7AB379-4CCD-43B6-A9B3-7C22BB5D9F11")
                },
                new Town()
                {
                    Name = "Milan",
                    CountryId = Guid.Parse("8A7AB379-4CCD-43B6-A9B3-7C22BB5D9F11")
                },
                new Town()
                {
                    Name = "Venice",
                    CountryId = Guid.Parse("8A7AB379-4CCD-43B6-A9B3-7C22BB5D9F11")
                }
            };

            return towns;
        }
    }
}
