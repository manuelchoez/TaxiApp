using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;
using TaxiApp.Domain.Entities;
using TaxiApp.Domain.Repository;

namespace TaxiApp.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> AddUserAsync(UserDto user)
        {
            User user1 = new User
            {
                CreatedAt = DateTime.Now,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                Username = user.Username,
                UserId = user.UserId
            };
            return await _userRepository.AddUserAsync(user1);
        }

        public async  Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            return (await _userRepository.GetAllUsersAsync()).Select(user => new UserDto
            {
                CreatedAt = user.CreatedAt,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                Username = user.Username,
                UserId = user.UserId
            });
        }

        public async  Task<UserDto> GetUserByIdAsync(int id)
        {
            User user = await _userRepository.GetUserByIdAsync(id);
            return new UserDto
            {
                CreatedAt = user.CreatedAt,
                Email = user.Email,
                PasswordHash = user.PasswordHash,
                Username = user.Username,
                UserId = user.UserId
            };
        }
    }
}
