namespace Yuksi.Domain;

public partial class Chat
{
    public Guid Id { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsGroup { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; set; } = new List<ChatMessage>();

    public virtual ICollection<ChatParticipant> ChatParticipants { get; set; } = new List<ChatParticipant>();
}
