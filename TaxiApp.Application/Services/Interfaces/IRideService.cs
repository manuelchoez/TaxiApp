using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Dto;
using TaxiApp.Domain.Entities;

namespace TaxiApp.Application.Services.Interfaces
{
    public interface IRideService
    {
        Task<RideDto> GetRideByIdAsync(int id);
        Task<IEnumerable<RideDto>> GetAllRidesAsync();
        Task<int> AddRideAsync(RideDto ride);
    }
}
