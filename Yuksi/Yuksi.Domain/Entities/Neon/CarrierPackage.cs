namespace Yuksi.Domain;

public partial class CarrierPackage
{
    public Guid Id { get; set; }

    public string PackageName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int DurationDays { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<CarrierPackageSubscription> CarrierPackageSubscriptions { get; set; } = new List<CarrierPackageSubscription>();

    public virtual ICollection<CarrierSubscriptionRequest> CarrierSubscriptionRequests { get; set; } = new List<CarrierSubscriptionRequest>();
}
