using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class MarketerShift
{
    public int Id { get; set; }

    public Guid MarketerId { get; set; }

    public DateTime ShiftStartTime { get; set; }

    public DateTime? ShiftEndTime { get; set; }

    public TimeSpan? ShiftDuration { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual MarketerUser Marketer { get; set; } = null!;
}
