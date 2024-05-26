using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Dto;

namespace TaxiApp.Application.Services.Interfaces
{
    public interface IDriverService
    {
        Task<DriverDto> Insert(DriverDto driver);
        Task<DriverDto> Update(DriverDto driver);
        Task<int> Delete(DriverDto driver);
        Task<DriverDto> GetDriverById(int id);
        Task<IEnumerable<DriverDto>> GetAllDrivers();
        Task<DriverDto> GetDriverByName(string name);
    }
}
