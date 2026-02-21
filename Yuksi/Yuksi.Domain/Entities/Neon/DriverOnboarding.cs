using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class DriverOnboarding
{
    public Guid DriverId { get; set; }

    public bool? ContractConfirmed { get; set; }

    public int? CountryId { get; set; }

    public int? WorkingType { get; set; }

    public int? VehicleType { get; set; }

    public int? VehicleCapacity { get; set; }

    public int? StateId { get; set; }

    public int? VehicleYear { get; set; }

    public int? Step { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public Guid? DealerId { get; set; }

    public string? UserType { get; set; }

    public long? CityId { get; set; }

    public string? FullAddress { get; set; }

    public string? WorkingAreaType { get; set; }
}
