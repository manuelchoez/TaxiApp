using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;

namespace TaxiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IDriverService _driverService;

        public DriverController(IDriverService driverService)
        {
            _driverService = driverService;
        }

        [HttpGet]
        [Route("GetAllDrivers")]
        public async Task<IActionResult> GetAllDrivers()
        {
            IEnumerable<DriverDto> response = await _driverService.GetAllDrivers();
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        [Route("GetDriverById")]
        public async Task<IActionResult> GetDriverById(int id)
        {
            DriverDto response = await _driverService.GetDriverById(id);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPost]
        [Route("InsertDriver")]
        public async Task<IActionResult> InsertDriver([FromBody] DriverDto driverDto)
        {
            DriverDto response = await _driverService.Insert(driverDto);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpPut]
        [Route("UpdateDriver")]
        public async Task<IActionResult> UpdateDriver([FromBody] DriverDto driverDto)
        {
            DriverDto response = await _driverService.Update(driverDto);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpDelete]
        [Route("DeleteDriver")]
        private async Task<IActionResult> DeleteDriver([FromBody] DriverDto driverDto)
        {
            int response = await _driverService.Delete(driverDto);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        [HttpGet]
        [Route("GetDriverByName")]
        public async Task<IActionResult> GetDriverByName(string name)
        {
            DriverDto response = await _driverService.GetDriverByName(name);
            return StatusCode(StatusCodes.Status200OK, response);
        }

        

    }
}
