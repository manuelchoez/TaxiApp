using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Dto;

namespace TaxiApp.Application.Services.Interfaces
{
    public interface IRideService
    {
        Task<RideDto> Insert(RideDto ride);
        Task<RideDto> Update(RideDto ride);
        Task<int> Delete(RideDto ride);
        Task<RideDto> GetRideById(int id);
        Task<IEnumerable<RideDto>> GetAllRides();
        Task<RideDto> GetRideByName(string name);
    }
}
