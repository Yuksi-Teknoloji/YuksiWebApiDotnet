using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Job
{
    public Guid Id { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerPhone { get; set; }

    public string? PickupAddress { get; set; }

    public string? DropAddress { get; set; }

    public decimal? Price { get; set; }

    public Guid? DriverId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
