namespace Yuksi.Domain;

public partial class Sale
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public decimal Amount { get; set; }

    public string? ProductType { get; set; }

    public string? PaymentMethod { get; set; }

    public double? Lat { get; set; }

    public double? Long { get; set; }

    public string Status { get; set; } = null!;

    public bool? Deleted { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual MarketerUser User { get; set; } = null!;
}
