using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Vehicle
{
    public Guid Id { get; set; }

    public Guid? DriverId { get; set; }

    public string? Make { get; set; }

    public string? Model { get; set; }

    public int? Year { get; set; }

    public string? Plate { get; set; }

    public string? VehicleType { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? VehicleDetails { get; set; }

    public virtual Driver? Driver { get; set; }

    public virtual ICollection<VehiclePhoto> VehiclePhotos { get; set; } = new List<VehiclePhoto>();

    public virtual VehicleType? VehicleTypeNavigation { get; set; }

    public virtual ICollection<VehicleFeature> FeatureNames { get; set; } = new List<VehicleFeature>();
}
