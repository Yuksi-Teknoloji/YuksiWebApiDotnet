namespace Yuksi.Domain;

public partial class DealerCompany
{
    public Guid Id { get; set; }

    public Guid DealerId { get; set; }

    public Guid CompanyId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Company Company { get; set; } = null!;

    public virtual Dealer Dealer { get; set; } = null!;
}
