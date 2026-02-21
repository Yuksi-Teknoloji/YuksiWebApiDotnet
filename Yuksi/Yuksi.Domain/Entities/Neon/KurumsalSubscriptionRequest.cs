namespace Yuksi.Domain;

public partial class KurumsalSubscriptionRequest
{
    public Guid Id { get; set; }

    public Guid CorporateUserId { get; set; }

    public Guid PackageId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public string? MerchantOid { get; set; }

    public string? PaymentStatus { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public virtual CorporateUser CorporateUser { get; set; } = null!;

    public virtual KurumsalPackage Package { get; set; } = null!;
}
