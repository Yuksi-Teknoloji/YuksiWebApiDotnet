using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class VehicleProduct
{
    public Guid Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public string ProductTemplate { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? VehicleFeatures { get; set; }

    public virtual VehicleType ProductTemplateNavigation { get; set; } = null!;

    public virtual ICollection<UserJob> UserJobs { get; set; } = new List<UserJob>();
}
