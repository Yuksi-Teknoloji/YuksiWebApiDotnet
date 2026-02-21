using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class ApplicationReview
{
    public Guid Id { get; set; }

    public string ApplicationType { get; set; } = null!;

    public string ApplicationId { get; set; } = null!;

    public Guid ReviewedBy { get; set; }

    public string Status { get; set; } = null!;

    public string? ReviewNotes { get; set; }

    public int? CallDurationSeconds { get; set; }

    public DateTime? ReviewedAt { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual SupportUser ReviewedByNavigation { get; set; } = null!;
}
