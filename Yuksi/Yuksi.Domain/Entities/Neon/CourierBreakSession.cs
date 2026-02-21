using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CourierBreakSession
{
    public Guid Id { get; set; }

    public Guid DriverId { get; set; }

    public Guid? BreakId { get; set; }

    public DateTime StartedAt { get; set; }

    public DateTime? EndedAt { get; set; }

    public int? DurationMinutes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual CourierBreak? Break { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}
