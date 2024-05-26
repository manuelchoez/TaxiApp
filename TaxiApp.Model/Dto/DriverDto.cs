using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Domain.Dto
{
    public class DriverDto
    {
        public int DriverId { get; set; }

        public string Name { get; set; } = null!;

        public string Phone { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string PasswordHash { get; set; } = null!;

        public string LicenseNumber { get; set; } = null!;

        public int? VehicleId { get; set; }

        public DateTime? CreatedAt { get; set; }
    }
}
