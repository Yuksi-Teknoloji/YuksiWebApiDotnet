namespace Yuksi.Domain;

public partial class MarketerCommission
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid PartnerId { get; set; }

    public decimal Amount { get; set; }

    public string SourceType { get; set; } = null!;

    public string Status { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual PartnerUser Partner { get; set; } = null!;

    public virtual MarketerUser User { get; set; } = null!;
}
