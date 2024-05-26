using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Domain.Dto
{
    public class VehicleDto
    {
        public int VehicleId { get; set; }

        public string Make { get; set; } = null!;

        public string Model { get; set; } = null!;

        public int Year { get; set; }

        public string LicensePlate { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }
    }
}
