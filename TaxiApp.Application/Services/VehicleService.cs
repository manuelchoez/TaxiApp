using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Application.Services.Interfaces;
using TaxiApp.Domain.Dto;
using TaxiApp.Domain.Entities;
using TaxiApp.Domain.Repository;

namespace TaxiApp.Application.Services
{
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _vehicleRepository;

        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        public Task<int> AddVehicleAsync(VehicleDto vehicle)
        {
            Vehicle vehicle1 = new Vehicle
            {
               CreatedAt = vehicle.CreatedAt,
               LicensePlate = vehicle.LicensePlate,
               Model = vehicle.Model,
               Make = vehicle.Make,
               Year = vehicle.Year,
               VehicleId   =  vehicle.VehicleId
            };
            return _vehicleRepository.AddVehicleAsync(vehicle1);
        }

        public async Task<IEnumerable<VehicleDto>> GetAllVehiclesAsync()
        {
            return (await _vehicleRepository.GetAllVehiclesAsync()).Select(v => new VehicleDto
            {
                CreatedAt = v.CreatedAt,
                LicensePlate = v.LicensePlate,
                Model = v.Model,
                Make = v.Make,
                Year = v.Year,
                VehicleId = v.VehicleId
            });
        }

        public async  Task<VehicleDto> GetVehicleByIdAsync(int id)
        {
            Vehicle vehicle = await _vehicleRepository.GetVehicleByIdAsync(id);
            return new VehicleDto
            {
                CreatedAt = vehicle.CreatedAt,
                LicensePlate = vehicle.LicensePlate,
                Model = vehicle.Model,
                Make = vehicle.Make,
                Year = vehicle.Year,
                VehicleId = vehicle.VehicleId
            };
        }
    }
}
