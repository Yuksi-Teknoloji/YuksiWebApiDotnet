namespace Yuksi.Domain;

public partial class CourierBreakSetting
{
    public Guid Id { get; set; }

    public int DailyBreakMinutes { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
