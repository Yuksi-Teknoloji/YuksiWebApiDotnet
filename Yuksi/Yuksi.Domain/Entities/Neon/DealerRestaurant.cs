namespace Yuksi.Domain;

public partial class DealerRestaurant
{
    public Guid Id { get; set; }

    public Guid DealerId { get; set; }

    public Guid RestaurantId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual Dealer Dealer { get; set; } = null!;

    public virtual Restaurant Restaurant { get; set; } = null!;
}
