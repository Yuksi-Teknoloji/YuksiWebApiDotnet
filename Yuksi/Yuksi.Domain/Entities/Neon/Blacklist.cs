namespace Yuksi.Domain;

public partial class Blacklist
{
    public Guid Id { get; set; }

    public string ApplicationType { get; set; } = null!;

    public string ApplicationId { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Name { get; set; }

    public string Reason { get; set; } = null!;

    public Guid AddedBy { get; set; }

    public DateTime? AddedAt { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual SupportUser AddedByNavigation { get; set; } = null!;
}
