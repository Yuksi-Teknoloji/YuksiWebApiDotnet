namespace Yuksi.Domain;

public partial class CourierPackage
{
    public Guid Id { get; set; }

    public string PackageName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int DurationDays { get; set; }

    public virtual ICollection<CourierPackageSubscription> CourierPackageSubscriptions { get; set; } = new List<CourierPackageSubscription>();

    public virtual ICollection<CourierSubscriptionRequest> CourierSubscriptionRequests { get; set; } = new List<CourierSubscriptionRequest>();
}
