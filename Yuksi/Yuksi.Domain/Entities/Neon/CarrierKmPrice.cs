using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CarrierKmPrice
{
    public Guid Id { get; set; }

    public string AreaType { get; set; } = null!;

    public string VehicleTemplate { get; set; } = null!;

    public decimal PricePerKm { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
