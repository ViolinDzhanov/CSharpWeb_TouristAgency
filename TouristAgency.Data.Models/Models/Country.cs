using static TouristAgency.Common.ApplicationConstants;
using System.ComponentModel.DataAnnotations;


namespace TouristAgency.Data.Models.Models
{
    public class Country
    {
        public Country()
        {
            Id = new Guid();
            Towns = new List<Town>();
            Addresses = new List<Address>();
        }
        [Key]
        public Guid Id { get; set; } 

        [Required]
        [MaxLength(CountryNameMaxLength)]
        public string Name { get; set; } = null!;
        public List<Town> Towns { get; set; }
        public List<Address> Addresses { get; set; } 
    }
}
