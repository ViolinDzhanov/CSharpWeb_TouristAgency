using static TouristAgency.Common.ApplicationConstants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace TouristAgency.Data.Models.Models
{
    public class Town
    {
        public Town()
        {
            Id = Guid.NewGuid();
            Addresses = new List<Address>();
        }

        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(TownNameMaxLength)]
        [Comment("Town name")]
        public string Name { get; set; } = null!;

        [Required]
        public Guid CountryId { get; set; }

        [Required]
        [ForeignKey(nameof(CountryId))]
        public Country Country { get; set; }

        public List<Address> Addresses { get; set; }
    }
}
