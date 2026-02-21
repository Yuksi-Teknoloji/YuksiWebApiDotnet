namespace Yuksi.Domain;

public partial class RestaurantMenu
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string Info { get; set; } = null!;

    public decimal Price { get; set; }

    public string? ImageUrl { get; set; }

    public Guid RestaurantId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Restaurant Restaurant { get; set; } = null!;
}
