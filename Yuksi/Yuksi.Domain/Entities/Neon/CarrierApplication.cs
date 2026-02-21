using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CarrierApplication
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string VehicleType { get; set; } = null!;

    public int? VehicleRegistrationYear { get; set; }

    public string? VehicleDocumentsUrl { get; set; }

    public string? CarrierDocumentsUrl { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ReviewedAt { get; set; }

    public Guid? ReviewedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
