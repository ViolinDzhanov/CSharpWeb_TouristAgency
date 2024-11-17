using static TouristAgency.Common.ApplicationConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace TouristAgency.Data.Models.Models
{
    public class Address
    {
        public Address()
        {
            Id = Guid.NewGuid();
            Customers = new List<Customer>();
        }
        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; } 

        [Required]
        [MaxLength(AddressStreetNameMaxLength)]
        [Comment("Street name")]
        public string StreetName { get; set; } =null!;

        [Comment("Street number")]
        public int StreetNumber { get; set; }

        [Required]
        public Guid TownId { get; set; }

        [ForeignKey(nameof(TownId))]
        public Town Town { get; set; } = null!;

        [Required]
        public Guid CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; } = null!;
        public List<Customer> Customers { get; set; }
    }
}
