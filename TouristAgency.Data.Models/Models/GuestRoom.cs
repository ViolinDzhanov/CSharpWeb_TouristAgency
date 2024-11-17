using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TouristAgency.Data.Models.Models
{
    public class GuestRoom
    {

        public Guid GuestId { get; set; }

        [Required]
        [ForeignKey(nameof(GuestId))]
        public Customer Guest { get; set; } = null!;

        public Guid RoomId { get; set; }

        [Required]
        [ForeignKey(nameof(RoomId))]
        public Room Room { get; set; } = null!;
    }
}