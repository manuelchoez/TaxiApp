using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp.Domain.Dto
{
    public class RideDto
    {
        public int RideId { get; set; }

        public int? UserId { get; set; }

        public int? DriverId { get; set; }

        public string Origin { get; set; } = null!;

        public string Destination { get; set; } = null!;

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public decimal? Cost { get; set; }

        public string Status { get; set; } = null!;

        public DateTime? CreatedAt { get; set; }
    }
}
