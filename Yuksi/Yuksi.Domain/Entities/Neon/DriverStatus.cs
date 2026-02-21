using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class DriverStatus
{
    public Guid DriverId { get; set; }

    public bool? Online { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
