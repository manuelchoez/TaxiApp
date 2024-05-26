using System;
using System.Collections.Generic;

namespace TaxiApp.Domain.Entities;

public partial class Payment
{
    public int PaymentId { get; set; }

    public int? RideId { get; set; }

    public decimal Amount { get; set; }

    public string Method { get; set; } = null!;

    public DateTime? PaymentTime { get; set; }

    public virtual Ride? Ride { get; set; }
}
