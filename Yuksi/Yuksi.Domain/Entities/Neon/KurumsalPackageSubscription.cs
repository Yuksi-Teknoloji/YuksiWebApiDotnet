using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class KurumsalPackageSubscription
{
    public Guid Id { get; set; }

    public Guid CorporateUserId { get; set; }

    public Guid PackageId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public int? RemainingKm { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual CorporateUser CorporateUser { get; set; } = null!;

    public virtual KurumsalPackage Package { get; set; } = null!;
}
