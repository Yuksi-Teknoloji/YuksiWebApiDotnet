using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class GpsTable
{
    public Guid DriverId { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}
