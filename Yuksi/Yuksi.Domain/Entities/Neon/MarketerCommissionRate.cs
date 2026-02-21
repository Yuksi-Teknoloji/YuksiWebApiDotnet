namespace Yuksi.Domain;

public partial class MarketerCommissionRate
{
    public Guid Id { get; set; }

    public string CommissionType { get; set; } = null!;

    public decimal Rate { get; set; }

    public string? Description { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
