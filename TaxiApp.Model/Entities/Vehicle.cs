using System;
using System.Collections.Generic;

namespace TaxiApp.Domain.Entities;

public partial class Vehicle
{
    public int VehicleId { get; set; }

    public string Make { get; set; } = null!;

    public string Model { get; set; } = null!;

    public int Year { get; set; }

    public string LicensePlate { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Driver> Drivers { get; set; } = new List<Driver>();
}
