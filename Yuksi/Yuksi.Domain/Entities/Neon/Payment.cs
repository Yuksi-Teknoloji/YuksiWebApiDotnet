namespace Yuksi.Domain;

public partial class Payment
{
    public Guid Id { get; set; }

    public Guid? JobId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Job? Job { get; set; }
}
