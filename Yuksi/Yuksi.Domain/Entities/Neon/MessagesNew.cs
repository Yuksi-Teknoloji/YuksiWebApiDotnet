namespace Yuksi.Domain;

public partial class MessagesNew
{
    public Guid Id { get; set; }

    public Guid ChatId { get; set; }

    public Guid SenderId { get; set; }

    public Guid ReceiverId { get; set; }

    public string? Text { get; set; }

    public bool IsDelivered { get; set; }

    public bool IsSeen { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DeliveredAt { get; set; }

    public DateTime? SeenAt { get; set; }
}
