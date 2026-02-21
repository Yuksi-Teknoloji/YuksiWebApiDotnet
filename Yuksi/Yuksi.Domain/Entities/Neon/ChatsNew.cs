namespace Yuksi.Domain;

public partial class ChatsNew
{
    public Guid Id { get; set; }

    public Guid FromId { get; set; }

    public Guid ToId { get; set; }

    public DateTime CreatedAt { get; set; }
}
