using System;
using System.Collections.Generic;

namespace TaxiApp.Domain.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<Ride> Rides { get; set; } = new List<Ride>();
}
