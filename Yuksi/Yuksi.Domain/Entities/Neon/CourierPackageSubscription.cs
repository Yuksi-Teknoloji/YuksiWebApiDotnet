namespace Yuksi.Domain;

public partial class CourierPackageSubscription
{
    public Guid Id { get; set; }

    public Guid? CourierId { get; set; }

    public Guid? PackageId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Driver? Courier { get; set; }

    public virtual CourierPackage? Package { get; set; }
}
