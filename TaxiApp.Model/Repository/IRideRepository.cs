using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Entities;

namespace TaxiApp.Domain.Repository
{
    public interface IRideRepository
    {
        Task<Ride> GetRideByIdAsync(int id);
        Task<IEnumerable<Ride>> GetAllRidesAsync();
        Task AddRideAsync(Ride ride);
    }
}
