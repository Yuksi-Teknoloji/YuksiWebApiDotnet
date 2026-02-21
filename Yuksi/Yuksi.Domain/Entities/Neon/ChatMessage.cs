namespace Yuksi.Domain;

public partial class ChatMessage
{
    public Guid Id { get; set; }

    public Guid? ChatId { get; set; }

    public Guid? MessageId { get; set; }

    public DateTime? InsertedAt { get; set; }

    public virtual Chat? Chat { get; set; }

    public virtual Message? Message { get; set; }
}
