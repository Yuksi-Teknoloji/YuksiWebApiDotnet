using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class CarrierSubscriptionRequest
{
    public Guid Id { get; set; }

    public Guid CourierId { get; set; }

    public Guid PackageId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? MerchantOid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Driver Courier { get; set; } = null!;

    public virtual CarrierPackage Package { get; set; } = null!;
}
