using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class MarketerUser
{
    public Guid Id { get; set; }

    public Guid PartnerId { get; set; }

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string? Phone { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public bool? IsActive { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<MarketerCommission> MarketerCommissions { get; set; } = new List<MarketerCommission>();

    public virtual ICollection<MarketerLocation> MarketerLocations { get; set; } = new List<MarketerLocation>();

    public virtual ICollection<MarketerShift> MarketerShifts { get; set; } = new List<MarketerShift>();

    public virtual PartnerUser Partner { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
