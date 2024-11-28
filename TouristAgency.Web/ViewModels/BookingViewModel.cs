using TouristAgency.Data.Models.Models.Enums;
using static TouristAgency.Common.ApplicationConstants;

namespace TouristAgency.Web.ViewModels
{
    public class BookingViewModel
    {
        //TODO: Reorganise the view model properties
        public string StartDate { get; set; } = DateTime.Now.ToString(DateAndTimeFormat);
        public string EndDate { get; set; } = DateTime.Now.ToString(DateAndTimeFormat);
        public RoomType RoomType { get; set; }
        public string HotelName { get; set; } = null!;
        public string CustomerId { get; set; } = null!;
    }
}
