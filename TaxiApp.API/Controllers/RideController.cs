using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;

namespace TaxiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private readonly IRideService _rideService;

        public RideController(IRideService rideService)
        {
            _rideService = rideService;
        }

        [HttpPost]
        [Route("AddRideAsync")]
        public async Task<IActionResult> AddRideAsync([FromBody] RideDto rideDto)
        {
            int response = await _rideService.AddRideAsync(rideDto);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        [Route("GetAllRidesAsync")]
        public async Task<IActionResult> GetAllRidesAsync()
        {
            IEnumerable<RideDto> response = await _rideService.GetAllRidesAsync();
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        [Route("GetRideByIdAsync")]
        public async Task<IActionResult> GetRideByIdAsync(int id)
        {
            RideDto response = await _rideService.GetRideByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, response);
        }
        
    }
}
