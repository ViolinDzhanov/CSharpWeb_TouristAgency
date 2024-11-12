using static TouristAgency.Common.ApplicationConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TouristAgency.Data.Models.Models
{
    public class Town
    {
        public Town()
        {
            Id = new Guid();
            Addresses = new List<Address>();
        }

        [Key]
        public Guid Id { get; set; } = new Guid();

        [Required]
        [MaxLength(TownNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public Guid CountryId { get; set; }

        [Required]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
