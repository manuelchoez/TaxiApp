using Microsoft.EntityFrameworkCore;
using TaxiApp.Domain.Entities;
using TaxiApp.Domain.Repository;
using TaxiApp.Infraestructure.Data;

public class VehicleRepository : IVehicleRepository
{
    private readonly TaxiDbContext _context;

    public VehicleRepository(TaxiDbContext context)
    {
        _context = context;
    }

    public async Task<int> AddVehicleAsync(Vehicle vehicle)
    {
        _context.Vehicles.Add(vehicle);
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Vehicle>> GetAllVehiclesAsync()
    {
        return await _context.Vehicles.ToListAsync();
    }

    public async Task<Vehicle> GetVehicleByIdAsync(int id)
    {
        return await _context.Vehicles.FindAsync(id);
    }
}
