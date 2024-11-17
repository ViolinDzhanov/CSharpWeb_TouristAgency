using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TouristAgency.Data.Models.Models.Enums;

namespace TouristAgency.Data.Models.Models
{
    public class Room
    {
        public Room()
        {
            this.Id = Guid.NewGuid();
            this.GuestsRooms = new List<GuestRoom>();
        }

        [Key]
        [Comment("Unique Identifier")]
        public Guid Id { get; set; }

        [Required]
        [Comment("Room type")]
        public RoomType RoomType { get; set; }

        [Comment("Price per night")]
        public decimal Price { get; set; }

        [Comment("Is the room available")]
        public bool IsAvailable { get; set; }

        [Required]
        public Guid HotelId { get; set; }

        [Required]
        [ForeignKey(nameof(HotelId))]
        public Hotel Hotel { get; set; }

        public ICollection<GuestRoom> GuestsRooms { get; set; }
    }
}