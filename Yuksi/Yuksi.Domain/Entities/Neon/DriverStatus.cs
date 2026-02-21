namespace Yuksi.Domain;

public partial class DriverStatus
{
    public Guid DriverId { get; set; }

    public bool? Online { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
