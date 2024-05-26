using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;
using TaxiApp.Domain.Entities;
using TaxiApp.Domain.Repository;

public class RideService : IRideService
{
    private readonly IRideRepository _rideRepository;

    public RideService(IRideRepository rideRepository)
    {
        _rideRepository = rideRepository;
    }

    public async Task<int> AddRideAsync(RideDto rideDto)
    {
        Ride ride = new Ride
        {
            Cost = rideDto.Cost,
            CreatedAt = rideDto.CreatedAt,
            Destination = rideDto.Destination,
            DriverId = rideDto.DriverId,
            EndTime = rideDto.EndTime,
            Origin = rideDto.Origin,
            RideId = rideDto.RideId,
            StartTime = rideDto.StartTime,
            Status = rideDto.Status,
            UserId = rideDto.UserId
        };
        return await _rideRepository.AddRideAsync(ride);
    }

    public async Task<IEnumerable<RideDto>> GetAllRidesAsync()
    {
        return (await _rideRepository.GetAllRidesAsync()).Select(r => new RideDto
        {
            Cost = r.Cost,
            CreatedAt = r.CreatedAt,
            Destination = r.Destination,
            DriverId = r.DriverId,
            EndTime = r.EndTime,
            Origin = r.Origin,
            RideId = r.RideId,
            StartTime = r.StartTime,
            Status = r.Status,
            UserId = r.UserId
        });
    }

    public async Task<RideDto> GetRideByIdAsync(int id)
    {
        return (await _rideRepository.GetRideByIdAsync(id)) is Ride ride ? new RideDto
        {
            Cost = ride.Cost,
            CreatedAt = ride.CreatedAt,
            Destination = ride.Destination,
            DriverId = ride.DriverId,
            EndTime = ride.EndTime,
            Origin = ride.Origin,
            RideId = ride.RideId,
            StartTime = ride.StartTime,
            Status = ride.Status,
            UserId = ride.UserId
        } : null!;
    }
}
