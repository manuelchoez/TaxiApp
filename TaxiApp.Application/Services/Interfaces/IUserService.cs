using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Dto;

namespace TaxiApp.Application.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> Insert(UserDto user);
        Task<UserDto> Update(UserDto user);
        Task<int> Delete(UserDto user);
        Task<UserDto> GetUserById(int id);
        Task<IEnumerable<UserDto>> GetAllUsers();
        Task<UserDto> GetUserByName(string name);
    }
}
