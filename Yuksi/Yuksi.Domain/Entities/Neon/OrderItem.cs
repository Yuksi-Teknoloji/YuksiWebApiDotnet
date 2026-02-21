namespace Yuksi.Domain;

public partial class OrderItem
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public decimal Total { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Order Order { get; set; } = null!;
}
