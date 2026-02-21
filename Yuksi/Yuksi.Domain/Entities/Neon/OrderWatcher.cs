using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class OrderWatcher
{
    public Guid OrderId { get; set; }

    public Guid RestaurantId { get; set; }

    public List<Guid>? AvalibleDrivers { get; set; }

    public List<Guid>? RejectedDrivers { get; set; }

    public DateTime? LastCheck { get; set; }

    public bool? Closed { get; set; }

    public virtual Order Order { get; set; } = null!;

    public virtual Restaurant Restaurant { get; set; } = null!;
}
