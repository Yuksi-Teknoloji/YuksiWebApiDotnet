namespace Yuksi.Domain;

public partial class SupportTicketsCourier
{
    public int Id { get; set; }

    public Guid? CourierId { get; set; }

    public string Email { get; set; } = null!;

    public string CourierName { get; set; } = null!;

    public string Subject { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string? Reply { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? RepliedAt { get; set; }

    public virtual Driver? Courier { get; set; }
}
