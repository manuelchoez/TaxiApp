using Microsoft.EntityFrameworkCore;
using TaxiApp.Domain.Entities;
using TaxiApp.Domain.Repository;
using TaxiApp.Infraestructure.Data;

public class RideRepository : IRideRepository
{
    private readonly TaxiDbContext _context;

    public RideRepository(TaxiDbContext context)
    {
        _context = context;
    }

    public async Task<int> AddRideAsync(Ride ride)
    {
        _context.Rides.Add(ride);
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Ride>> GetAllRidesAsync()
    {
        return await _context.Rides.ToListAsync();
    }

    public async Task<Ride> GetRideByIdAsync(int id)
    {
        Ride? ride = new Ride();
        ride = await _context.Rides.FindAsync(id);
        return ride;
    }
}
