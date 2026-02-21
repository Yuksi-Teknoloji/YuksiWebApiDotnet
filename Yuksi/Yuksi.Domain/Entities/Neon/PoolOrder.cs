namespace Yuksi.Domain;

public partial class PoolOrder
{
    public Guid OrderId { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Order Order { get; set; } = null!;
}
