namespace Yuksi.Domain;

public partial class Message
{
    public Guid Id { get; set; }

    public Guid SenderId { get; set; }

    public string SenderType { get; set; } = null!;

    public Guid ReceiverId { get; set; }

    public string ReceiverType { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateTime? SentAt { get; set; }

    public DateTime? DeliveredAt { get; set; }

    public DateTime? ReadAt { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();
}
