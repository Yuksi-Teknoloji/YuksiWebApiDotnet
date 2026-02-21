namespace Yuksi.Domain;

public partial class SupportTicket
{
    public int Id { get; set; }

    public Guid? RestaurantId { get; set; }

    public string Email { get; set; } = null!;

    public string RestaurantName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? Reply { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? RepliedAt { get; set; }

    public virtual Restaurant? Restaurant { get; set; }
}
