public class RideRepository : IRideRepository
{
    private readonly TaxiAppDbContext _context;

    public RideRepository(TaxiAppDbContext context)
    {
        _context = context;
    }

    public async Task AddRideAsync(Ride ride)
    {
        _context.Rides.Add(ride);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Ride>> GetAllRidesAsync()
    {
        return await _context.Rides.ToListAsync();
    }

    public async Task<Ride> GetRideByIdAsync(int id)
    {
        return await _context.Rides.FindAsync(id);
    }
}
