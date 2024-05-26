using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Dto;
using TaxiApp.Domain.Entities;

namespace TaxiApp.Application.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<VehicleDto> GetVehicleByIdAsync(int id);
        Task<IEnumerable<VehicleDto>> GetAllVehiclesAsync();
        Task<int> AddVehicleAsync(VehicleDto vehicle);
    }
}
