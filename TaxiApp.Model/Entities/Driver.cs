using System;
using System.Collections.Generic;

namespace TaxiApp.Domain.Entities;

public partial class Driver
{
    public int DriverId { get; set; }

    public string Name { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string LicenseNumber { get; set; } = null!;

    public int? VehicleId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Ride> Rides { get; set; } = new List<Ride>();

    public virtual Vehicle? Vehicle { get; set; }
}
