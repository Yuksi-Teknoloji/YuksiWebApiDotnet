using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class OnboardingCorporate
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid FileId { get; set; }

    public string Status { get; set; } = null!;

    public Guid? ReviewedBy { get; set; }

    public DateTime? ReviewedAt { get; set; }

    public string? RejectionReason { get; set; }

    public string? AdminNotes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual File File { get; set; } = null!;

    public virtual CorporateUser User { get; set; } = null!;
}
