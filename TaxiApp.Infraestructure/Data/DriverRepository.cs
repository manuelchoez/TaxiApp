using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Entities;
using TaxiApp.Domain.Repository;

namespace TaxiApp.Infraestructure.Data
{
    public class DriverRepository : IDriverRepository
    {
        private readonly TaxiDbContext _context;
                
        public DriverRepository(TaxiDbContext context)
        {
            _context = context;
        }

        public async Task<int> Delete(Driver driver)
        {           
            Driver? item = _context.Drivers.Find(driver.DriverId);
            if (item!= null)
            {
                 _context.Drivers.Remove(item);
            }
           return await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Driver>> GetAllDrivers()
        {
            return await _context.Drivers.ToListAsync();
        }

        public async Task<Driver> GetDriverById(int id)
        {
            Driver? item = await _context.Drivers.FindAsync(id);
            return item;
        }

        public async Task<Driver> GetDriverByName(string name)
        {
            Driver driver = await _context.Drivers.Where(d => d.Name == name).FirstAsync();
            return driver;
        }

        public async Task<Driver> Insert(Driver driver)
        {
            await _context.Drivers.AddAsync(driver);
            _context.SaveChangesAsync();
            driver = await GetDriverByName(driver.Name);
            return driver;
        }

        public async Task<Driver> Update(Driver driver)
        {
           Driver item = _context.Drivers.Find(driver.DriverId);
          if (item != null)
              {
                item.Name = driver.Name;
                item.Email = driver.Email;
                item.Phone = driver.Phone;
                item.LicenseNumber = driver.LicenseNumber;
                item.VehicleId = driver.VehicleId;
                _context.Drivers.Update(item);
                await _context.SaveChangesAsync();
            }
            return driver;
        }
    }
}
