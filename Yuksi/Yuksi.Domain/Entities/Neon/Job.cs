using Yuksi.Domain.Enums;

namespace Yuksi.Domain;

public sealed class Job
{
    public Guid Id { get; set; }
    public string? CustomerName { get; set; }
    public string? CustomerPhone { get; set; }
    public string? PickupAddress { get; set; }
    public string? DropAddress { get; set; }
    public decimal? Price { get; set; }
    public JobStatus Status { get; set; }
    public Guid? DriverId { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
