namespace Yuksi.Domain;

public partial class DeviceToken
{
    public Guid Id { get; set; }

    public string TargetType { get; set; } = null!;

    public Guid TargetId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }
}
