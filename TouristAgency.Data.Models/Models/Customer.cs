using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TouristAgency.Common.ApplicationConstants;


namespace TouristAgency.Data.Models.Models
{
    public class Customer : IdentityUser<Guid>
    {
        public Customer()
        {
            this.Id = Guid.NewGuid();
            this.GuestsRooms = new List<GuestRoom>();
            this.Bookings = new List<Booking>();
        }

        [PersonalData]
        [MaxLength(CustomerFirstNameMaxLength)]
        [Comment("Customer first name")]
        public string? FirstName { get; set; }

        [PersonalData]
        [MaxLength(CustomerLastNameMaxLength)]
        [Comment("Customer last name")]
        public string? LastName { get; set; } = null!;

        [Comment("Customer address")]
        Guid AddressId { get; set; }

        [Required]
        [ForeignKey(nameof(AddressId))]
        public Address Address { get; set; } = null!;
        public ICollection<GuestRoom> GuestsRooms { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
