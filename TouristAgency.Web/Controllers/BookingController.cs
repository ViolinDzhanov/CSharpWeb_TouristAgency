using Microsoft.AspNetCore.Mvc;
using TouristAgency.Web.Data;
using TouristAgency.Web.ViewModels;

namespace TouristAgency.Web.Controllers
{
    public class BookingController : Controller
    {
        private readonly TouristAgencyDbContext context;

        public BookingController(TouristAgencyDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            //var model = new BookingViewModel();

            return View(/*model*/);
        }
    }
}
