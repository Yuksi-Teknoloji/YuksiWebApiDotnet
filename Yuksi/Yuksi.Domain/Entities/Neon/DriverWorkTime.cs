using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class DriverWorkTime
{
    public Guid DriverId { get; set; }

    public int TotalWorkSeconds { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}
