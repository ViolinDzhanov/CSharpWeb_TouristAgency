using static TouristAgency.Common.ApplicationConstants;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace TouristAgency.Data.Models.Models
{
    public class Country
    {
        public Country()
        {
            Id = Guid.NewGuid();
            Towns = new List<Town>();        
        }

        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; } 

        [Required]
        [MaxLength(CountryNameMaxLength)]
        [Comment("Country name")]
        public string Name { get; set; } = null!;
        public List<Town> Towns { get; set; }
    }
}
