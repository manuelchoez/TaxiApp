using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;

namespace TaxiApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAllUsersAsync")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            IEnumerable<UserDto> response = await _userService.GetAllUsersAsync();
            return StatusCode(StatusCodes.Status200OK, response);
        }
        [HttpGet]
        [Route("GetUserByIdAsync")]
        public async Task<IActionResult> GetUserByIdAsync(int id)
        {
            UserDto response = await _userService.GetUserByIdAsync(id);
            return StatusCode(StatusCodes.Status200OK, response);
        }
        
        [HttpPost]
        [Route("AddUserAsync")]
        public async Task<IActionResult> AddUserAsync([FromBody] UserDto userDto)
        {
            int response = await _userService.AddUserAsync(userDto);
            return StatusCode(StatusCodes.Status200OK, response);
        }

    }
}
