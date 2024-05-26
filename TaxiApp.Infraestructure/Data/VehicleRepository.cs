public class VehicleRepository : IVehicleRepository
{
    private readonly TaxiAppDbContext _context;

    public VehicleRepository(TaxiAppDbContext context)
    {
        _context = context;
    }

    public async Task AddVehicleAsync(Vehicle vehicle)
    {
        _context.Vehicles.Add(vehicle);
        await _context.SaveChangesAsync();
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
