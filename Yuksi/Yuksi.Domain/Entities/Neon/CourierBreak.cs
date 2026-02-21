namespace Yuksi.Domain;

public partial class CourierBreak
{
    public Guid Id { get; set; }

    public Guid DriverId { get; set; }

    public DateOnly BreakDate { get; set; }

    public int? TotalBreakMinutes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<CourierBreakSession> CourierBreakSessions { get; set; } = new List<CourierBreakSession>();

    public virtual Driver Driver { get; set; } = null!;
}
