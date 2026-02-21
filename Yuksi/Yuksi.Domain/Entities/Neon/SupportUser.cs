using System;
using System.Collections.Generic;

namespace Yuksi.Infrastructure;

public partial class SupportUser
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public List<int>? Access { get; set; }

    public bool? Deleted { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<ApplicationReview> ApplicationReviews { get; set; } = new List<ApplicationReview>();

    public virtual ICollection<Blacklist> Blacklists { get; set; } = new List<Blacklist>();
}
