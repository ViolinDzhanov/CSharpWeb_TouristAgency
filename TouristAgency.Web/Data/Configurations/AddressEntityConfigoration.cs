using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TouristAgency.Data.Models.Models;

namespace TouristAgency.Web.Data.Configurations
{
    public class AddressEntityConfigoration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            ICollection<Address> addresses = CreateAddresses();
            builder.HasData(addresses);
        }

        private ICollection<Address> CreateAddresses()
        {
            List<Address> addresses = new List<Address>()
            {
                new Address()
                {
                    StreetName = "Vitosha",
                    StreetNumber = 1,
                    TownId = Guid.Parse("CD11F2E1-CB7E-4798-B5A7-14137D47B5F1"),
                    CountryId = Guid.Parse("D225932B-E49B-4F30-89A3-A1863C6857F6")
                },
                new Address()
                {
                    StreetName = "Rakovski Street",
                    StreetNumber = 49,
                    TownId = Guid.Parse("CD11F2E1-CB7E-4798-B5A7-14137D47B5F1"),
                    CountryId = Guid.Parse("D225932B-E49B-4F30-89A3-A1863C6857F6")
                },
                new Address()
                {
                   StreetName = "Tsarigradsko shose",
                   StreetNumber = 67,
                   TownId = Guid.Parse("CD11F2E1-CB7E-4798-B5A7-14137D47B5F1"),
                   CountryId = Guid.Parse("D225932B-E49B-4F30-89A3-A1863C6857F6")
                },

            };

            return addresses;
        }
    }
}
