namespace Yuksi.Domain;

public partial class RestaurantCourier
{
    public Guid Id { get; set; }

    public Guid? RestaurantId { get; set; }

    public Guid? CourierId { get; set; }

    public DateTime? AssignedAt { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Driver? Courier { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}
