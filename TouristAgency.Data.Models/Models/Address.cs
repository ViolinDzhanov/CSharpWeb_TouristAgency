using static TouristAgency.Common.ApplicationConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TouristAgency.Data.Models.Models
{
    public class Address
    {
        public Address()
        {
            Id = new Guid();
            Customers = new List<Customer>();
        }
        [Key]
        public Guid Id { get; set; } 

        [Required]
        [MaxLength(AddressStreetNameMaxLength)]
        public string StreetName { get; set; } =null!;
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
