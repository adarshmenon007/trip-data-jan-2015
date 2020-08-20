using Microsoft.AspNetCore.Mvc;
using TripsDataJan2015.Data;

namespace TripsDataJan2015.Controllers{

    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripService _service;

        //create a constructor so then we can inject the service to be able to use it in our endpoints
        public TripsController(ITripService service)
        {
            this._service = service;
        }

        [HttpGet("GetAllTrips")]
        public IActionResult GetAllTrips()
        {
            var allTrips = _service.GetAllTrips();
            
            return Ok(allTrips);
        }        
    }
}