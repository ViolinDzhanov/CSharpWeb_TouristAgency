using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace TouristAgency.Data.Models.Models
{
    public class Customer : IdentityUser<Guid>
    {
        public Customer()
        {
            this.Id = Guid.NewGuid();
        }

        Guid AddressId { get; set; }

        [Required]
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;
    }
}
