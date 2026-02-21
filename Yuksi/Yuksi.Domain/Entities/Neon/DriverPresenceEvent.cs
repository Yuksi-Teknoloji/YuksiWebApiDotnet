namespace Yuksi.Domain;

public partial class DriverPresenceEvent
{
    public Guid Id { get; set; }

    public Guid DriverId { get; set; }

    public bool IsOnline { get; set; }

    public DateTime AtUtc { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}
