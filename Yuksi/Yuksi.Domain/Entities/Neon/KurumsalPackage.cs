namespace Yuksi.Domain;

public partial class KurumsalPackage
{
    public Guid Id { get; set; }

    public string PackageName { get; set; } = null!;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int DurationDays { get; set; }

    public int? IncludedKm { get; set; }

    public decimal? OveruseKmPrice { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual ICollection<KurumsalPackageSubscription> KurumsalPackageSubscriptions { get; set; } = new List<KurumsalPackageSubscription>();

    public virtual ICollection<KurumsalSubscriptionRequest> KurumsalSubscriptionRequests { get; set; } = new List<KurumsalSubscriptionRequest>();
}
