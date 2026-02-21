using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class RestaurantPackagePrice
{
    public Guid Id { get; set; }

    public Guid RestaurantId { get; set; }

    public decimal UnitPrice { get; set; }

    public int? MinPackage { get; set; }

    public int? MaxPackage { get; set; }

    public string? Note { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Restaurant Restaurant { get; set; } = null!;
}
