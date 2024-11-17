using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TouristAgency.Common.ApplicationConstants;


namespace TouristAgency.Data.Models.Models
{
    public class Hotel
    {
        public Hotel()
        {
            this.Id = Guid.NewGuid();         
        }

        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(HotelNameMaxLength)]
        [Comment("Hotel name")]
        public string Name { get; set; } = null!;

        [Required]
        public Guid AddressId { get; set; }

        [Required]
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;
    }
}
