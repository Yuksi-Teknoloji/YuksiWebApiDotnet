namespace Yuksi.Domain;

public partial class DriverWorkTime
{
    public Guid DriverId { get; set; }

    public int TotalWorkSeconds { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Driver Driver { get; set; } = null!;
}
