using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Data.Models.Models
{
    public class Booking
    {
        public Booking()
        {
            this.Id = Guid.NewGuid();

        }

        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Guid HotelId { get; set; }

        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}