namespace Yuksi.Domain;

public partial class CourierDocument
{
    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public Guid FileId { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual File File { get; set; } = null!;
}
