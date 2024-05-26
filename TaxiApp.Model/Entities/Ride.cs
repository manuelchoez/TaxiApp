using System;
using System.Collections.Generic;

namespace TaxiApp.Domain.Entities;

public partial class Ride
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

    public virtual Driver? Driver { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual User? User { get; set; }
}
