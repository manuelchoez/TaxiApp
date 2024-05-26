using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Dto;

namespace TaxiApp.Application.Services.Interfaces
{
    public interface IVehicleService
    {
        Task<VehicleDto> Insert(VehicleDto vehicle);
        Task<VehicleDto> Update(VehicleDto vehicle);
        Task<int> Delete(VehicleDto vehicle);
        Task<VehicleDto> GetVehicleById(int id);
        Task<IEnumerable<VehicleDto>> GetAllVehicles();
        Task<VehicleDto> GetVehicleByName(string name);
    }
}
