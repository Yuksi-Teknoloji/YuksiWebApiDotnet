using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class VehicleFeature
{
    public Guid Id { get; set; }

    public string Feature { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string FeatureCode { get; set; } = null!;

    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();
}
