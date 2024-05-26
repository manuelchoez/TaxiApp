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
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public async Task<int> Delete(DriverDto driver)
        {
            Driver driver1 = new Driver
            {
                DriverId = driver.DriverId,
                Name = driver.Name,
                Email = driver.Email,
                Phone = driver.Phone,
                PasswordHash = driver.PasswordHash,
                LicenseNumber = driver.LicenseNumber,
                VehicleId = driver.VehicleId,
                CreatedAt = driver.CreatedAt
            };
            return await _driverRepository.Delete(driver1);
        }

        public async Task<IEnumerable<DriverDto>> GetAllDrivers()
        {
            List<DriverDto> driverDtos = new List<DriverDto>();
            IEnumerable<Driver> drivers =  await _driverRepository.GetAllDrivers();
            foreach (var driver in drivers)
            {
                DriverDto driverDto = new DriverDto
                {
                    DriverId = driver.DriverId,
                    Name = driver.Name,
                    Email = driver.Email,
                    Phone = driver.Phone,
                    PasswordHash = driver.PasswordHash,
                    LicenseNumber = driver.LicenseNumber,
                    VehicleId = driver.VehicleId,
                    CreatedAt = driver.CreatedAt
                };
                driverDtos.Add(driverDto);
            }
            return driverDtos;
        }

        public async Task<DriverDto> GetDriverById(int id)
        {
            DriverDto driverDto = new DriverDto();
            Driver driver =  await _driverRepository.GetDriverById(id);
            if (driver != null)
            {
                driverDto = new DriverDto
                {
                    DriverId = driver.DriverId,
                    Name = driver.Name,
                    Email = driver.Email,
                    Phone = driver.Phone,
                    PasswordHash = driver.PasswordHash,
                    LicenseNumber = driver.LicenseNumber,
                    VehicleId = driver.VehicleId,
                    CreatedAt = driver.CreatedAt
                };               
            }
            return driverDto;
        }

        public async Task<DriverDto> GetDriverByName(string name)
        {
           DriverDto driverDto = new DriverDto();
            Driver driver =  await _driverRepository.GetDriverByName(name);
            if (driver != null)
            {
                driverDto = new DriverDto
                {
                    DriverId = driver.DriverId,
                    Name = driver.Name,
                    Email = driver.Email,
                    Phone = driver.Phone,
                    PasswordHash = driver.PasswordHash,
                    LicenseNumber = driver.LicenseNumber,
                    VehicleId = driver.VehicleId,
                    CreatedAt = driver.CreatedAt
                };               
            }
            return driverDto;
        }

        public async Task<DriverDto> Insert(DriverDto driver)
        {

            Driver driver1 = new Driver
            {
                DriverId = driver.DriverId,
                Name = driver.Name,
                Email = driver.Email,
                Phone = driver.Phone,
                PasswordHash = driver.PasswordHash,
                LicenseNumber = driver.LicenseNumber,
                VehicleId = driver.VehicleId,
                CreatedAt = driver.CreatedAt
            };
            Driver driver2 = await _driverRepository.Insert(driver1);
            DriverDto driverDto = new DriverDto
            {
                DriverId = driver2.DriverId,
                Name = driver2.Name,
                Email = driver2.Email,
                Phone = driver2.Phone,
                PasswordHash = driver2.PasswordHash,
                LicenseNumber = driver2.LicenseNumber,
                VehicleId = driver2.VehicleId,
                CreatedAt = driver2.CreatedAt
            };
            return driverDto;

        }

        public async Task<DriverDto> Update(DriverDto driver)
        {
           Driver driver1 = new Driver
            {
                DriverId = driver.DriverId,
                Name = driver.Name,
                Email = driver.Email,
                Phone = driver.Phone,
                PasswordHash = driver.PasswordHash,
                LicenseNumber = driver.LicenseNumber,
                VehicleId = driver.VehicleId,
                CreatedAt = driver.CreatedAt
            };
            Driver driver2 = await _driverRepository.Update(driver1);
            DriverDto driverDto = new DriverDto
            {
                DriverId = driver2.DriverId,
                Name = driver2.Name,
                Email = driver2.Email,
                Phone = driver2.Phone,
                PasswordHash = driver2.PasswordHash,
                LicenseNumber = driver2.LicenseNumber,
                VehicleId = driver2.VehicleId,
                CreatedAt = driver2.CreatedAt
            };
            return driverDto;
        }
    }
}
