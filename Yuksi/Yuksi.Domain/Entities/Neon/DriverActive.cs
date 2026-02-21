namespace Yuksi.Domain;

public partial class DriverActive
{
    public Guid DriverId { get; set; }

    public bool? IsOnline { get; set; }

    public DateTime? OnlineSince { get; set; }

    public DateTime? LastStateChange { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}
