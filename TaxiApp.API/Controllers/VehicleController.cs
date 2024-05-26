using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;

namespace TaxiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleService _vehicleService;

        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        [HttpGet]
        [Route("GetAllVehiclesAsync")]
        public async Task<IActionResult> GetAllVehiclesAsync()
        {
            IEnumerable<VehicleDto> response = await _vehicleService.GetAllVehiclesAsync();
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        [Route("GetVehicleByIdAsync")]
        public async Task<IActionResult> GetVehicleByIdAsync(int id)
        {
            VehicleDto response = await _vehicleService.GetVehicleByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        [Route("AddVehicleAsync")]
        public async Task<IActionResult> AddVehicleAsync([FromBody] VehicleDto vehicleDto)
        {
            int response = await _vehicleService.AddVehicleAsync(vehicleDto);
            return StatusCode(StatusCodes.Status200OK, response);
        }
    }
}
