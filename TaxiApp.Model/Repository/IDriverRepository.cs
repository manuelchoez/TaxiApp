using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiApp.Domain.Entities;

namespace TaxiApp.Domain.Repository
{
    public interface IDriverRepository
    {
        
        Task<Driver> Insert(Driver driver);
        Task<Driver> Update(Driver driver);
        Task<int> Delete(Driver driver);
        Task<Driver> GetDriverById(int id);
        Task<IEnumerable<Driver>> GetAllDrivers();
        Task<Driver> GetDriverByName(string name);
    }
}
