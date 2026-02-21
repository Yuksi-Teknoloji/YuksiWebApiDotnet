using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class UserJobOffer
{
    public Guid Id { get; set; }

    public Guid JobId { get; set; }

    public Guid CourierId { get; set; }

    public decimal? DistanceKm { get; set; }

    public int? RadiusTier { get; set; }

    public string? Status { get; set; }

    public DateTime? SentAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public DateTime? RespondedAt { get; set; }

    public virtual Driver Courier { get; set; } = null!;

    public virtual UserJob Job { get; set; } = null!;
}
