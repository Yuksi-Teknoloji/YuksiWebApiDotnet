using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class Campaign
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public double DiscountRate { get; set; }

    public string? Rule { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }
}
